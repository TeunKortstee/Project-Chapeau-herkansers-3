using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNieuwItem : UserControl
    {
        private Form1 form;
        private bool isEditing;
        private MenuItem currentMenuItem;
        private Personeel currentPersoneel;

        public UserControlNieuwItem(Personeel currentPersoneel, bool isEditing)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.currentPersoneel = currentPersoneel;
            this.isEditing = isEditing;
            if (!isEditing)
            {
                SetNewPersoneelLogic(Functie.Serveerder);
            }
            else
            {
                SetEditPersoneelLogic(currentPersoneel);
            }
        }
        public UserControlNieuwItem(MenuItem currentMenuItem, bool isEditing, MenuItemControl menuItemControl)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.currentMenuItem = currentMenuItem;
            this.isEditing = isEditing;
            if (!isEditing)
            {
                SetNewMenuItemLogic(MenuType.Lunch);
            }
            else
            {
                SetEditMenuItemLogic(this.currentMenuItem, menuItemControl);
            }
            SetButtonTags(menuItemControl);
        }
        #region Menu Specific Logic
        private void SetEditPersoneelLogic(Personeel personeel)
        {
            SetCurrentObjectInfo(personeel.AchterNaam, personeel.Email);
            SetNewPersoneelLogic(personeel.Functie);
        }
        private void SetEditMenuItemLogic(MenuItem menuItem, MenuItemControl menuItemControl)
        {
            switch (menuItemControl)
            {
                case MenuItemControl.Menu:
                    SetNewMenuItemLogic(menuItem.MenuType);
                    SetCurrentObjectInfo(menuItem.Naam, menuItem.Prijs.ToString());
                    break;
                case MenuItemControl.Voorraad:
                    SetVoorraadLogic(menuItem.Voorraad);
                    break;
            }
            btnCancel.Tag = menuItemControl;
            btnConfirm.Tag = menuItemControl;
        }
        private void SetButtonTags(MenuItemControl menuItemControl)
        {
            btnCancel.Tag = menuItemControl;
            btnConfirm.Tag = menuItemControl;
        }
        private void SetNewMenuItemLogic(MenuType menu)
        {
            SetObjectText("MenuItem", "Naam", "Prijs", "0,00", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
        }

        private void SetNewPersoneelLogic(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "Functie");
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
        }
        private void SetCurrentObjectInfo(string firstField, string secondField)
        {
            txt1.Text = firstField;
            txt2.Text = secondField;
        }
        private void SetVoorraadLogic(int voorraad)
        {
            lblObject.Text = $"Voorraad";
            btnAdd.Visible = true;
            btnSubtract.Visible = true;
            txtStock.Visible = true;
            HideSecondAndThirdFields();
            txt1.Visible = false;
            lbl1.Text = "In Voorraad";
            txtStock.Text = $"{voorraad}";
        }
        private void HideSecondAndThirdFields()
        {
            field2.Visible = false;
            field3.Visible = false;
            lbl2.Visible = false;
            lblEnum.Visible = false;
            txt2.Visible = false;
            cmbType.Visible = false;
        }
        private void SetObjectText(string objectType, string name, string emailOrPrice, string placeholder1, string enumType)
        {
            lblObject.Text = $"Nieuw {objectType}";
            lbl1.Text = name;
            lbl2.Text = emailOrPrice;
            txt2.PlaceholderText = placeholder1;
            lblEnum.Text = enumType;
        }
        #endregion

        #region Functionalities
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnConfirm.Tag)
                {
                    case MenuItemControl.Menu:
                        InsertMenuItem();
                        UpdateMenuItem();
                        break;
                    case MenuItemControl.Voorraad:
                        UpdateVoorraad();
                        break;
                    default:
                        InsertPersoneel();
                        UpdatePersoneel();
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            ReturnToOverview();
        }
        #region Send to Database
        private void InsertPersoneel()
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem) || isEditing)
            {
                return;
            }
            PersoneelService personeelService = new PersoneelService();
            Personeel newPersoneel = new Personeel(txt1.Text, personeelService.CreateEmail(txt2.Text), (Functie)cmbType.SelectedItem);
            personeelService.InsertPersoneel(newPersoneel);
        }
        private void UpdatePersoneel()
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem) || !isEditing)
            {
                return;
            }
            this.currentPersoneel.AchterNaam = txt1.Text;
            this.currentPersoneel.Email = txt2.Text;
            this.currentPersoneel.Functie = (Functie)cmbType.SelectedItem;
            PersoneelService personeelService = new PersoneelService();
            personeelService.UpdatePersoneel(this.currentPersoneel);
        }
        private void InsertMenuItem()
        {
            if (!AreValidMenuItemInputs(txt1.Text, txt2.Text, (MenuType)cmbType.SelectedItem) || isEditing)
            {
                return;
            }
            MenuItemService menuItemService = new MenuItemService();
            MenuItem newMenuItem = new MenuItem(txt1.Text, ParsePrice(txt2.Text), chkAlcoholisch.Checked, (MenuType)cmbType.SelectedItem);
            menuItemService.AddNewMenuItem(newMenuItem);
        }
        private void UpdateMenuItem()
        {
            if (!AreValidMenuItemInputs(txt1.Text, txt2.Text, (MenuType)cmbType.SelectedItem) || !isEditing)
            {
                return;
            }
            this.currentMenuItem.Naam = txt1.Text;
            this.currentMenuItem.Prijs = ParsePrice(txt2.Text);
            this.currentMenuItem.IsAlcoholisch = chkAlcoholisch.Checked;
            this.currentMenuItem.MenuType = (MenuType)cmbType.SelectedItem;
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.UpdateMenuItem(this.currentMenuItem);
        }
        private void UpdateVoorraad()
        {
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                DisplayErrorMessage(InvalidInput());
                return;
            }
            MenuItemService menuItemService = new MenuItemService();
            this.currentMenuItem.Voorraad = stock;
            menuItemService.UpdateMenuItemStock(this.currentMenuItem);
        }
        private void InsertMenuItemInkomen(MenuItem menuItem, MenuType menuType)
        {
            InkomenService inkomenService = new InkomenService();
            switch (menuType)
            {
                case MenuType.Drank:
                    inkomenService.InsertInkomen(menuItem, BereidingsPlek.Bar);
                    break;
                default:
                    inkomenService.InsertInkomen(menuItem, BereidingsPlek.Keuken);
                    break;
            }
        }
        #endregion
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview();
        }
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem is not MenuType)
            {
                return;
            }
            chkAlcoholisch.Visible = CheckIfDrinks((MenuType)cmbType.SelectedItem);
        }
        private bool CheckIfDrinks(MenuType menu)
        {
            if (menu == MenuType.Drank)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region ErrorHandling

        #region MenuItemHandling
        private bool AreValidMenuItemInputs(string nameInput, string priceInput, MenuType selectedItem)
        {
            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrEmpty(priceInput) || !Enum.IsDefined(typeof(MenuType), selectedItem))
            {
                DisplayErrorMessage("Velden zijn niet geldig");
                return false;
            }
            return true;
        }
        private double ParsePrice(string priceInput)
        {
            if (!double.TryParse(priceInput, out double price))
            {
                throw new Exception("Vul een geldige prijs in");
            }
            return price;
        }

        #endregion

        #region PersoneelHandling
        private bool AreValidPersoneelInputs(string nameInput, string emailInput, Functie selectedItem)
        {
            if (!IsEmpty(nameInput, emailInput) || !ValidCharacters(nameInput, emailInput) || !Enum.IsDefined(typeof(Functie), selectedItem))
            {
                return false;
            }
            return true;
        }
        private bool ValidCharacters(string nameInput, string emailInput)
        {
            foreach (char character in emailInput)
            {
                if (!char.IsLetter(character) && character != '_' && character != '.')
                {
                    DisplayErrorMessage("Username is niet geldig");
                    return false;
                }
            }
            foreach (char character in nameInput)
            {
                if (!char.IsLetter(character) && character != ' ')
                {
                    DisplayErrorMessage("Achternaam is niet geldig");
                    return false;
                }
            }
            return true;
        }
        private bool IsEmpty(string nameInput, string emailInput)
        {
            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrWhiteSpace(nameInput))
            {
                DisplayErrorMessage("Vul alle velden in");
                return false;
            }
            return true;
        }
        #endregion

        #region VoorraadHandeling
        private void CheckStockMinAndMax(int newStock)
        {
            int minimum = 0;

            if (newStock <= minimum)
            {
                btnSubtract.Enabled = false;
                txtStock.Text = minimum.ToString();
            }
            else
            {
                btnSubtract.Enabled = true;
                btnAdd.Enabled = true;
                txtStock.Text = newStock.ToString();
            }
        }
        #endregion

        private string InvalidInput()
        {
            return "Vul een geldig getal in";
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorNewObject.Visible = true;
            lblErrorNewObject.Text = errorMessage;
        }

        #endregion

        private void ReturnToOverview()
        {
            if (btnCancel.Tag == null)
            {
                form.SwitchPanels(new UserControlPersoneel());
            }
            else
            {
                form.SwitchPanels(new UserControlMenuItem((MenuItemControl)btnCancel.Tag));
            }
        }

        #region VoorraadLogic
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateStock(1);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            UpdateStock(-1);
        }
        private void UpdateStock(int change)
        {
            if (!int.TryParse(txtStock.Text, out int stock))
            {
                DisplayErrorMessage(InvalidInput());
                return;
            }
            int newStock = stock + change;
            CheckStockMinAndMax(newStock);
        }
        #endregion
    }
}
