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

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlNewObject : UserControl
    {
        private Form1 form;
        private MenuType menu;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlNewObject(Form1 form1, Functie functie)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayEmployeeElements(functie);
        }
        public UserControlNewObject(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayMenuElements(menu);
        }
        private void DisplayMenuElements(MenuType menu)
        {
            lblObject.Text = "Nieuw MenuItem";
            lbl1.Text = "Naam";
            lbl2.Text = "Prijs";
            txt2.PlaceholderText = "0,00";
            lbl3.Text = "Voorraad";
            lblEnum.Text = "Menu";
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
        }
        private void DisplayEmployeeElements(Functie functie)
        {
            lblObject.Text = "Nieuw Werknemer";
            lbl1.Text = "Achternaam";
            lbl2.Text = "Email";
            lbl3.Text = "Wachtwoord";
            lblEnum.Text = "Functie";
            cmbType.DataSource = Enum.GetValues(typeof(Functie));
            cmbType.SelectedItem = functie;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                try
                {
                    MenuItem newMenuItem = menuItemService.CreateMenuItem(txt1.Text, decimal.Parse(txt2.Text), chkAlcoholisch.Checked, cmbType.SelectedIndex, int.Parse(txt3.Text));
                    menuItemService.AddNewMenuItem(newMenuItem);
                    form.Switchpanels(new UserControlManageOverview(form, (MenuType)newMenuItem.MenuId));
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
                    // Personeel newEmployee = personeelService.CreatePersoneel(txt1.Text, txt2.Text, chkAlcoholisch.Checked, (Functie)cmbType.SelectedIndex);
                    // personeelService.InsertPersoneel(newEmployee);
                    // form.Switchpanels(new UserControlManageOverview(form, (MenuType)newEmployee.Functie));
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
            form.Switchpanels(new UserControlManageOverview(form, this.menu));
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
    }
}
