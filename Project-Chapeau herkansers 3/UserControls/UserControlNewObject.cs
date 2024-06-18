using Model;
using Service;
using System.Text.RegularExpressions;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNewObject : UserControl
    {
        private Form1 form;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlNewObject(Functie function)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayEmployeeElements(function);
        }
        public UserControlNewObject(MenuType menu)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayMenuElements(menu);
        }
        #region DisplayUIElements

        #region Menu Item
        private void DisplayMenuElements(MenuType menu)
        {
            SetObjectText("MenuItem", "Naam", "Prijs", "€ 0,00", "Voorraad", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
            btnCancel.Tag = menu;
            btnConfirm.Tag = menu;
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "De_Graaf", "Wachtwoord", "Functie");
            txt3.Enabled = false;
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
            btnCancel.Tag = function;
            btnConfirm.Tag = function;
        }
        #endregion

        private void SetObjectText(string objectType, string name, string emailOrPrice, string placeholder1, string numbers, string enumType)
        {
            lblObject.Text = $"Nieuw {objectType}";
            lbl1.Text = name;
            lbl2.Text = emailOrPrice;
            txt2.PlaceholderText = placeholder1;
            txt3.PlaceholderText = "0000";
            lbl3.Text = numbers;
            lblEnum.Text = enumType;
        }
        #endregion

        #region Functionalities
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                try
                {
                    MenuItem newMenuItem = menuItemService.CreateMenuItem(txt1.Text, double.Parse(txt2.Text), chkAlcoholisch.Checked, (MenuType)cmbType.SelectedItem, int.Parse(txt3.Text));
                    menuItemService.AddNewMenuItem(newMenuItem);
                    form.SwitchPanels(new UserControlManageOverview((MenuType)btnConfirm.Tag));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                try
                {
                    if (CheckNameInputs(txt1.Text, txt2.Text))
                    {
                        Personeel newEmployee = personeelService.CreatePersoneel(txt1.Text, txt2.Text, (Functie)cmbType.SelectedItem);
                        personeelService.InsertPersoneel(newEmployee);
                        form.SwitchPanels(new UserControlManageOverview((Functie)btnConfirm.Tag));
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview((MenuType)btnCancel.Tag));
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                CheckIfDrinks((MenuType)cmbType.SelectedItem);
            }
        }
        private void CheckIfDrinks(MenuType menu)
        {
            if (menu == MenuType.Drank)
            {
                chkAlcoholisch.Visible = true;
            }
            else
            {
                chkAlcoholisch.Visible = false;
            }
        }
        private bool CheckNameInputs(string nameInput, string emailInput)
        {
            string namePattern = @"^[\p{L} ]+$";
            string emailPattern = @"^[a-zA-Z0-9._]+$";
            if (string.IsNullOrWhiteSpace(emailInput))
            {
                throw new FormatException("Vul een username in");
            }
            if (string.IsNullOrWhiteSpace(nameInput))
            {
                throw new FormatException("Vul een achternaam in");
            }
            if (!Regex.IsMatch(nameInput, namePattern))
            {
                throw new FormatException("Achternaam is niet geldig");
            }
            if (!Regex.IsMatch(emailInput, emailPattern))
            {
                throw new FormatException("Vul alleen een username in met een punt of laag streepje, zonder spaties");
            }
            return true;
        }
        #endregion
    }
}
