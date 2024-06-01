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
                //btn2.Location = new Point(158, 194);
                btn1.Text = "Lunch";
                btn2.Text = "Diner";
                btn3.Text = "Drank";
                FillMenuListView((MenuType)1);
            }
            else
            {
                lblOverview.Text = "Personeel";
                btn1.Text = "Serveerder";
                btn2.Text = "Keuken";
                btn3.Text = "Bar";
                FillEmployeeListView((Functie)1);
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            lsvDatabaseItems.Clear();
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)1);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lsvDatabaseItems.Clear();
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)2);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lsvDatabaseItems.Clear();
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)3);
            }
            else
            {
                FillEmployeeListView((Functie)3);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.Switchpanels(new UserControlManager(form));
        }
    }
}
