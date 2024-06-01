using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlOverview : UserControl
    {
        private Form1 form1;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlOverview(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayUIElements();
        }
        public UserControlOverview(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.form1 = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayUIElements();
        }
        private void DisplayUIElements()
        {
            if (this.personeelService == null) 
            {
                lblOverview.Text = "Menu";
                lsvDatabaseItems.Columns.Add("Item", 250);
                lsvDatabaseItems.Columns.Add("In Voorraad", 60);
                cmbCategorie.DataSource = Enum.GetValues(typeof(MenuType));
                cmbCategorie.SelectedIndex = 2;
                FillMenuListView((MenuType)cmbCategorie.SelectedItem);
            }
            else
            {
                lblOverview.Text = "Personeel";
                lsvDatabaseItems.Columns.Add("Naam", 100);
                lsvDatabaseItems.Columns.Add("Functie", 150);
                cmbCategorie.DataSource = Enum.GetValues(typeof(Functie));
                cmbCategorie.SelectedIndex = 0;
                FillEmployeeListView((Functie)cmbCategorie.SelectedItem);
            }
        }
        private void FillMenuListView(MenuType menuType)
        {
            List<MenuItem> menuItems = menuItemService.GetMenuItemsByMenu(menuType);
            foreach (MenuItem menuItem in menuItems)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Prijs.ToString());
            }
        }
        private void FillEmployeeListView(Functie functie)
        {

        }
    }
}
