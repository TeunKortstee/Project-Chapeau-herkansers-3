using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNewObject : UserControl
    {
        private Form1 form;
        public UserControlNewObject(Functie function)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayEmployeeElements(function);
        }
        public UserControlNewObject(MenuType menu)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayMenuElements(menu);
        }
        #region DisplayUIElements

        #region Menu Item
        private void DisplayMenuElements(MenuType menu)
        {
            SetObjectText("MenuItem", "Naam", "Prijs", "€ 0,00", "10", "Voorraad", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
            btnCancel.Tag = menu;
            btnConfirm.Tag = menu;
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "", "Wachtwoord", "Functie");
            txt3.Enabled = false;
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
            btnCancel.Tag = function;
            btnConfirm.Tag = function;
        }
        #endregion

        private void SetObjectText(string objectType, string name, string emailOrPrice, string placeholder1, string placeholder2, string numbers, string enumType)
        {
            lblObject.Text = $"Nieuw {objectType}";
            lbl1.Text = name;
            lbl2.Text = emailOrPrice;
            txt2.PlaceholderText = placeholder1;
            txt3.PlaceholderText = placeholder2;
            lbl3.Text = numbers;
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
                    default:
                        DisplayErrorMessage("Er ging iets mis");
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
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
            form.SwitchPanels(new UserControlManageOverview((Functie)btnConfirm.Tag));
        }
        private void InsertMenuItem()
        {
            if (!AreValidMenuItemInputs(txt1.Text, txt2.Text, txt3.Text, (MenuType)cmbType.SelectedItem))
            {
                return;
            }
            MenuItemService menuItemService = new MenuItemService();
            MenuItem newMenuItem = new MenuItem(txt1.Text, ParsePrice(txt2.Text), chkAlcoholisch.Checked, (MenuType)cmbType.SelectedItem, ParseStock(txt3.Text));
            menuItemService.AddNewMenuItem(newMenuItem);
            form.SwitchPanels(new UserControlManageOverview((MenuType)btnConfirm.Tag));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview((MenuType)btnCancel.Tag));
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
        private bool AreValidMenuItemInputs(string nameInput, string priceInput, string stockInput, MenuType selectedItem)
        {
            if (string.IsNullOrEmpty(nameInput) || string.IsNullOrEmpty(priceInput) || string.IsNullOrEmpty(stockInput) || !Enum.IsDefined(typeof(MenuType), selectedItem))
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
        private int ParseStock(string stockInput)
        {
            int stock = 0;
            if (!int.TryParse(stockInput, out stock))
            {
                throw new Exception("Vul een geldige voorraad in");
            }
            return stock;
        }

        #endregion

        #region PersoneelHandling
        private bool AreValidPersoneelInputs(string nameInput, string emailInput, Functie selectedItem)
        {
            if (!IsEmpty(nameInput, emailInput) || !ValidCharacters(nameInput, emailInput) || !Enum.IsDefined(typeof(Functie), selectedItem))
            {
                DisplayErrorMessage("Velden zijn niet geldig");
                return false;
            }
            return true;
        }
        private bool ValidCharacters(string nameInput, string emailInput)
        {
            foreach (char character in emailInput)
            {
                if (!char.IsLetter(character) || character != '_' || character != '.')
                {
                    DisplayErrorMessage("Username is niet geldig");
                    return false;
                }
            }
            foreach (char character in nameInput)
            {
                if (!char.IsLetter(character) || character != ' ')
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
    }
}
