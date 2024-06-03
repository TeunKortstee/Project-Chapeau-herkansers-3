﻿using Model;
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
        private MenuType selectedMenuType;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlOverview(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
        }
        public UserControlOverview(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.selectedMenuType = menu;
            this.form = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayMenuElements();
        }
        private void DisplayUIElements()
        {
            if (this.personeelService == null)
            {
                DisplayMenuElements();
            }
            else
            {
                lblOverview.Text = "Personeel";
                btn1.Text = Functie.Serveerder.ToString();
                btn2.Text = Functie.Keuken.ToString();
                btn3.Text = Functie.Bar.ToString();
                FillEmployeeListView((Functie)1);
            }
        }
        private void DisplayMenuElements()
        {
            lblOverview.Text = "Menu";
            //btn2.Location = new Point(158, 194);
            btn1.Text = MenuType.Lunch.ToString();
            btn2.Text = MenuType.Diner.ToString();
            btn3.Text = MenuType.Drank.ToString();
            RenableButtons();
            FillMenuListView(this.selectedMenuType);
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                this.selectedMenuType = MenuType.Lunch;
                FillMenuListView(this.selectedMenuType);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
            RenableButtons();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                this.selectedMenuType = MenuType.Diner;
                FillMenuListView(this.selectedMenuType);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
            RenableButtons();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                this.selectedMenuType = MenuType.Drank;
                FillMenuListView(this.selectedMenuType);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
            RenableButtons();
        }
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Id", 60);
            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);


            List<MenuItem> selectedMenu = menuItemService.GetAllMenuItems(menuType);
            foreach (MenuItem menuItem in selectedMenu)
            {
                ListViewItem item = new ListViewItem(menuItem.MenuItemId.ToString());
                item.SubItems.Add(menuItem.Naam);
                item.SubItems.Add(menuItem.Voorraad.ToString());
                item.Tag = menuItem;
                lsvDatabaseItems.Items.Add(item);
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

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDatabaseItems.SelectedItems.Count > 0)
                {
                    ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                    MenuItem selecteMenuItem = (MenuItem)selectedLsvItem.Tag;
                    this.form.Switchpanels(new UserControlAdjustStock(form, selecteMenuItem));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecteer een item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDatabaseItems.SelectedItems.Count > 0)
                {
                    ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                    MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
                    menuItemService.DeleteMenuItem(selectedMenuItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecteer een item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FillMenuListView(this.selectedMenuType);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.form.Switchpanels(new UserControlNewObject(form, this.selectedMenuType));
        }
        private void RenableButtons()
        {
            switch (selectedMenuType)
            {
                case MenuType.Lunch:
                    btn1.Enabled = false;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    break;
                case MenuType.Diner:
                    btn1.Enabled = true;
                    btn2.Enabled = false;
                    btn3.Enabled = true;
                    break;
                case MenuType.Drank:
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = false;
                    break;
            }
        }

        private void btn1_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn1);
        }

        private void btn2_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn2);
        }

        private void btn3_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn3);
        }
        private void SetEnableColor(System.Windows.Forms.Button button)
        {
            //button.BackColor = Color.FromArgb(255, 234, 219, 202);
            if (button.Enabled)
            {
                // Enabled
                button.BackColor = Color.FromArgb(255, 138, 210, 176);
            }
            else
            {
                // Disabled
                button.BackColor = Color.FromArgb(114, 138, 210, 176);
            }
        }
    }
}