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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlOverview : UserControl
    {
        private Form1 form;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlOverview(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayUIElements();
        }
        public UserControlOverview(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayUIElements();
        }
        private void DisplayUIElements()
        {
            if (this.personeelService == null)
            {
                lblOverview.Text = "Menu";
                cmbCategorie.DataSource = Enum.GetValues(typeof(MenuType));
                cmbCategorie.SelectedIndex = 2;
                FillMenuListView((MenuType)cmbCategorie.SelectedIndex);
            }
            else
            {
                lblOverview.Text = "Personeel";
                cmbCategorie.DataSource = Enum.GetValues(typeof(Functie));
                cmbCategorie.SelectedIndex = 0;
                FillEmployeeListView((Functie)cmbCategorie.SelectedIndex);
            }
        }
        private void RefreshListView()
        {
            lsvDatabaseItems.Clear();
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)cmbCategorie.SelectedIndex);
            }
            else
            {
                FillEmployeeListView((Functie)cmbCategorie.SelectedIndex);
            }
        }
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);


            Model.Menu menu = menuItemService.GetAllItems();
            foreach (MenuItem menuItem in menu.MenuItems)
            {
                if (menuItem.MenuId == (int)menuType)
                {
                    ListViewItem item = new ListViewItem(menuItem.Naam);
                    item.SubItems.Add(menuItem.Prijs.ToString());
                    item.SubItems.Add(menuItem.Voorraad.ToString());
                    item.Tag = menuItem;
                    lsvDatabaseItems.Items.Add(item);
                }
            }
        }
        private void FillEmployeeListView(Functie functie)
        {
            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            List<Personeel> personeel = personeelService.GetAllPersoneel();
            foreach (Personeel werknemer in personeel)
            {
                ListViewItem item = new ListViewItem(werknemer.VoorNaam);
                item.SubItems.Add(werknemer.Functie.ToString());
                item.Tag = werknemer;
                lsvDatabaseItems.Items.Add(item);
            }

        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.Switchpanels(new UserControlManager(form));
        }
    }
}
