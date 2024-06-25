﻿using Model;
using Service;
using System.Text.RegularExpressions;

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
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "0000", "Wachtwoord", "Functie");
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
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
        }
        private void InsertPersoneel()
        {
            if (CheckNameInputs(txt1.Text, txt2.Text))
            {
                PersoneelService personeelService = new PersoneelService();
                Personeel newPersoneel = new Personeel(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem);
                personeelService.InsertPersoneel(newPersoneel);
                form.SwitchPanels(new UserControlManageOverview((Functie)btnConfirm.Tag));
            }
        }
        private void InsertMenuItem()
        {
            if (!double.TryParse(txt2.Text, out double price))
            {
                DisplayErrorMessage("Vul een geldige prijs in");
            }
            MenuItemService menuItemService = new MenuItemService();
            MenuItem newMenuItem = new MenuItem(txt1.Text, price, chkAlcoholisch.Checked, (MenuType)cmbType.SelectedItem, int.Parse(txt3.Text));
            menuItemService.AddNewMenuItem(newMenuItem);
            form.SwitchPanels(new UserControlManageOverview((MenuType)btnConfirm.Tag));
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview((MenuType)btnCancel.Tag));
        }
        #region MenuItemHandling

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

        #region PersoneelHandling
        private bool CheckNameInputs(string nameInput, string emailInput)
        {
            ValidateName(nameInput);
            ValidateEmail(emailInput);
            return true;
        }
        private void ValidateEmail(string emailInput)
        {
            if (string.IsNullOrWhiteSpace(emailInput))
            {
                throw new Exception("Vul een username in");
            }
            foreach (char character in emailInput)
            {
                if (!char.IsLetter(character) || character != '_' || character != '.')
                {
                    throw new Exception("Vul alleen een username in met een punt of laag streepje, zonder spaties");
                }
            }
        }
        private void ValidateName(string nameInput)
        {
            if (string.IsNullOrEmpty(nameInput))
            {
                throw new FormatException("Vul een achternaam in");
            }
            foreach(char character in nameInput)
            {
                if (!char.IsLetter(character) || character != ' ')
                {
                    throw new FormatException("Achternaam is niet geldig");
                }
            }
        }
        #endregion
        private void DisplayErrorMessage(string errorMessage)
        {
            lblError.Text = errorMessage;
        }
        #endregion
    }
}
