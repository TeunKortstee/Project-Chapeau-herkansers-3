using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNewObject : UserControl
    {
        private Form1 form;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlNewObject(Functie functie)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayEmployeeElements(functie);
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
            SetObjectText("MenuItem", "Naam", "Prijs", "0,00", "Voorraad", "10", "Menu");
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
            btnCancel.Tag = menu;
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie function)
        {
            SetObjectText("Werknemer", "Achternaam", "Email", "@", "Wachtwoord", "0000", "Functie");
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = function;
            btnCancel.Tag = function;
        }
        #endregion

        private void SetObjectText(string objectType, string name, string emailOrPrice, string placeholder1, string numbers, string placeholder2, string enumType)
        {
            lblObject.Text = $"Nieuw {objectType}";
            lbl1.Text = name;
            lbl2.Text = emailOrPrice;
            txt2.PlaceholderText = placeholder1;
            lbl3.Text = numbers;
            txt3.PlaceholderText = placeholder2;
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
                    MenuItem newMenuItem = menuItemService.CreateMenuItem(txt1.Text, float.Parse(txt2.Text), chkAlcoholisch.Checked, cmbType.SelectedIndex, int.Parse(txt3.Text));
                    menuItemService.AddNewMenuItem(newMenuItem);
                    form.SwitchPanels(new UserControlManageOverview((MenuType)newMenuItem.MenuId));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Fout: Probleem met velden");
                    return;
                }
            }
            else
            {
                try
                {
                    //Personeel newEmployee = personeelService.CreatePersoneel(txt1.Text, txt2.Text, , (Functie)cmbType.SelectedIndex);
                    //personeelService.InsertPersoneel(newEmployee);
                    //form.SwitchPanels(new UserControlManageOverview((MenuType)newEmployee.Functie));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Fout: Probleem met velden");
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
            CheckIfDrinks((MenuType)cmbType.SelectedItem);
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
        #endregion
    }
}
