using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNieuwItem : UserControl
    {
        private Form1 form;
        public UserControlNieuwItem(Functie function)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayEmployeeElements(function);
        }
        public UserControlNieuwItem(MenuType menu)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayMenuElements(menu);
        }
        #region DisplayUIElements

        #region Menu Item
        private void DisplayMenuElements(MenuType menu)
        {
            SetObjectText("MenuItem", "Naam", "Prijs", "0,00", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
            btnCancel.Tag = menu;
            btnConfirm.Tag = menu;
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "Functie");
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
            btnCancel.Tag = function;
            btnConfirm.Tag = function;
        }
        #endregion

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
                    case MenuType:
                        InsertMenuItem();
                        break;
                    case Functie:
                        InsertPersoneel();
                        break;
                }
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
        }
        private void InsertPersoneel()
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem))
            {
                return;
            }
            PersoneelService personeelService = new PersoneelService();
            Personeel newPersoneel = new Personeel(txt1.Text, personeelService.CreateEmail(txt2.Text), (Functie)cmbType.SelectedItem);
            personeelService.InsertPersoneel(newPersoneel);
            ReturnToOverview();
        }
        private void InsertMenuItem()
        {
            if (!AreValidMenuItemInputs(txt1.Text, txt2.Text, (MenuType)cmbType.SelectedItem))
            {
                return;
            }
            MenuItemService menuItemService = new MenuItemService();
            MenuItem newMenuItem = new MenuItem(txt1.Text, ParsePrice(txt2.Text), chkAlcoholisch.Checked, (MenuType)cmbType.SelectedItem);
            newMenuItem.MenuItemId = menuItemService.AddNewMenuItem(newMenuItem);
            InsertMenuItemInkomen(newMenuItem, (MenuType)cmbType.SelectedItem);
            ReturnToOverview();
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
            double price = 0;
            if (!double.TryParse(priceInput, out price))
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
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorNewObject.Visible = true;
            lblErrorNewObject.Text = errorMessage;
        }
        #endregion
        private void ReturnToOverview()
        {
            switch (btnCancel.Tag)
            {
                case MenuType:
                    form.SwitchPanels(new UserControlItemOverzicht((MenuType)btnCancel.Tag));
                    break;
                case Functie:
                    form.SwitchPanels(new UserControlItemOverzicht((Functie)btnCancel.Tag));
                    break;
            }
        }
    }
}
