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
        public UserControlNewObject(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
        }
        public UserControlNewObject(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            this.menu = menu;
            DisplayMenuElements(menu);
        }
        private void DisplayUIElements()
        {
            if (this.personeelService == null)
            {
                //btn2.Location = new Point(158, 194);
            }
            else
            {
                lblObject.Text = "Nieuw Werknemer";
                lbl1.Text = "Voornaam";
                lbl2.Text = "Achternaam";
                lbl3.Text = "Email";
                lblEnum.Text = "Functie";
                cmbType.DataSource = Enum.GetValues(typeof(Functie));
                cmbType.SelectedIndex = 0;
            }
        }
        private void DisplayMenuElements(MenuType menu)
        {
            lblObject.Text = "Nieuw MenuItem";
            lbl1.Text = "Naam";
            lbl2.Text = "Prijs";
            lbl3.Text = "Voorraad";
            lblEnum.Text = "Menu";
            cmbType.DataSource = Enum.GetValues(typeof(MenuType));
            cmbType.SelectedItem = menu;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                try
                {
                    MenuItem newMenuItem = menuItemService.CreateMenuItem(txt2.Text, decimal.Parse(txt3.Text), chkAlcoholisch.Checked, cmbType.SelectedIndex, int.Parse(txt3.Text));
                    menuItemService.AddNewMenuItem(newMenuItem);
                    form.Switchpanels(new UserControlOverview(form, (MenuType)newMenuItem.MenuId));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Prijs, Voorraad: voer een getal in");
                    return;
                }
                //finally
                //{
                //    form.Switchpanels(new UserControlOverview(form, MenuType.Drank));
                //}

            }
            else
            {
                return;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            form.Switchpanels(new UserControlOverview(form, this.menu));
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
