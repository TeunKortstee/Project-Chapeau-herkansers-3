using DAL;
using Model;
using Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlItemAanpas : UserControl
    {
        private Form1 form;
        public UserControlItemAanpas(Personeel personeel)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayEmployeeElements(personeel);
        }
        public UserControlItemAanpas(MenuItem menuItem)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayMenuElements(menuItem);
        }
        #region DisplayUIElements

        #region Menu Item
        private void DisplayMenuElements(MenuItem menuItem)
        {
            SetObjectText("MenuItem", "Naam", "Prijs", "0,00", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            SetCurrentMenuItemData(menuItem);
        }
        private void SetCurrentMenuItemData(MenuItem menuItem)
        {
            txt1.Text = menuItem.Naam;
            txt2.Text = menuItem.Prijs.ToString();
            cmbType.SelectedItem = menuItem.MenuType;
            btnCancel.Tag = menuItem.MenuType;
            btnConfirm.Tag = menuItem;
            chkAlcoholisch.Checked = menuItem.IsAlcoholisch;
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Personeel personeel)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "Functie");
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            SetCurrentPersoneelData(personeel);
        }
        private void SetCurrentPersoneelData(Personeel personeel)
        {
            int domainIndex = personeel.Email.IndexOf('@');
            txt1.Text = personeel.AchterNaam;
            txt2.Text = personeel.Email.Substring(0, domainIndex);
            cmbType.SelectedItem = personeel.Functie;
            btnCancel.Tag = personeel.Functie;
            btnConfirm.Tag = personeel;
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
                    case MenuItem:
                        UpdateMenuItem((MenuItem)btnConfirm.Tag);
                        break;
                    case Personeel:
                        UpdatePersoneel((Personeel)btnConfirm.Tag);
                        break;
                }
                ReturnToOverview();
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void UpdatePersoneel(Personeel selectedPersoneel)
        {
            if (!AreValidPersoneelInputs(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem))
            {
                return;
            }
            PersoneelService personeelService = new PersoneelService();
            selectedPersoneel.AchterNaam = txt1.Text;
            selectedPersoneel.Email = personeelService.CreateEmail(txt2.Text);
            selectedPersoneel.Functie = (Functie)cmbType.SelectedItem;
            personeelService.UpdatePersoneel(selectedPersoneel);
        }
        private void UpdateMenuItem(MenuItem selectedMenuItem)
        {
            if (!AreValidMenuItemInputs(txt1.Text, txt2.Text, (MenuType)cmbType.SelectedItem))
            {
                return;
            }
            MenuItemService menuItemService = new MenuItemService();
            selectedMenuItem.Naam = txt1.Text;
            selectedMenuItem.Prijs = ParsePrice(txt2.Text);
            selectedMenuItem.MenuType = (MenuType)cmbType.SelectedItem;
            menuItemService.UpdateMenuItem(selectedMenuItem);
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
