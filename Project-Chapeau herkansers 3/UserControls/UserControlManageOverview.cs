using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlManageOverview : UserControl
    {
        private Form1 form;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlManageOverview(Functie functie)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = new PersoneelService();
            this.menuItemService = null;
            DisplayEmployeeElements(functie);
        }
        public UserControlManageOverview(MenuType menu)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayMenuElements(menu);
        }
        #region DisplayUIElements

        #region MenuItem
        private void DisplayMenuElements(MenuType menuType)
        {
            lblOverview.Text = "Menu";
            SetObjectText("Menu Item");
            DisplayMenuButtons(menuType);
            FillMenuListView(menuType);
        }
        #region Buttons - MenuItem
        private void DisplayMenuButtons(MenuType menuType)
        {
            btn1.Tag = MenuType.Lunch;
            btn1.Text = MenuType.Lunch.ToString();
            btn2.Tag = MenuType.Diner;
            btn2.Text = MenuType.Diner.ToString();
            btn3.Tag = MenuType.Drank;
            btn3.Text = MenuType.Drank.ToString();
            RenableMenuButtons(menuType);
        }
        private void RenableMenuButtons(MenuType menuType)
        {
            switch (menuType)
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
            btnAddNew.Tag = menuType;
        }
        #endregion
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie functie)
        {
            lblOverview.Text = "Personeel";
            SetObjectText("Werknemer");
            DisplayEmployeeButtons(functie);
            FillEmployeeListView(functie);
        }
        #region Buttons - Employee
        private void DisplayEmployeeButtons(Functie functie)
        {
            btn1.Tag = Functie.Serveerder;
            btn1.Text = Functie.Serveerder.ToString();
            btn2.Tag = Functie.Keuken;
            btn2.Text = Functie.Keuken.ToString();
            btn3.Tag = Functie.Bar;
            btn3.Text = Functie.Bar.ToString();
            chkManagers.Visible = true;
            chkManagers.Tag = Functie.Manager;
            btnAdjust.Visible = false;
            btnRemove.Location = new Point(14, 651);
            RenableEmployeeButtons(functie);
        }
        private void RenableEmployeeButtons(Functie functie)
        {
            switch (functie)
            {
                case Functie.Serveerder:
                    btn1.Enabled = false;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Keuken:
                    btn1.Enabled = true;
                    btn2.Enabled = false;
                    btn3.Enabled = true;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Bar:
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = false;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Manager:
                    btn1.Enabled = true;
                    btn2.Enabled = true;
                    btn3.Enabled = true;
                    chkManagers.CheckState = CheckState.Checked;
                    break;
            }
            btnAddNew.Tag = functie;
        }
        #endregion
        private void SetObjectText(string objectType)
        {
            btnAddNew.Text = $"{objectType} toevoegen";
        }
        #endregion

        #region ListView
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Id", 60);
            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);


            List<MenuItem> selectedMenu = menuItemService.GetMenuItemsByMenu(menuType);
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
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Id", 60);
            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            List<Personeel> personeel = personeelService.GetPersoneelByFunctie(functie);
            foreach (Personeel werknemer in personeel)
            {
                ListViewItem item = new ListViewItem(werknemer.Id.ToString());
                item.SubItems.Add(werknemer.AchterNaam);
                item.SubItems.Add(werknemer.Functie.ToString());
                item.Tag = werknemer;
                lsvDatabaseItems.Items.Add(item);
            }
        }
        #endregion

        #endregion

        #region Top Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)btn1.Tag);
                RenableMenuButtons((MenuType)btn1.Tag);
            }
            else
            {
                FillEmployeeListView((Functie)btn1.Tag);
                RenableEmployeeButtons((Functie)btn1.Tag);
            }
        }
        private void btn1_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)btn2.Tag);
                RenableMenuButtons((MenuType)btn2.Tag);
            }
            else
            {
                FillEmployeeListView((Functie)btn2.Tag);
                RenableEmployeeButtons((Functie)btn2.Tag);
            }
        }
        private void btn2_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                FillMenuListView((MenuType)btn3.Tag);
                RenableMenuButtons((MenuType)btn3.Tag);
            }
            else
            {
                FillEmployeeListView((Functie)btn3.Tag);
                RenableEmployeeButtons((Functie)btn3.Tag);
            }
        }
        private void btn3_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn3);
        }
        private void chkManagers_Click(object sender, EventArgs e)
        {
            RenableEmployeeButtons((Functie)chkManagers.Tag);
            FillEmployeeListView((Functie)chkManagers.Tag);
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
        #endregion

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckItemSelected())
                {
                    ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                    MenuItem selecteMenuItem = (MenuItem)selectedLsvItem.Tag;
                    this.form.SwitchPanels(new UserControlAdjustStock(selecteMenuItem));
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
                if (CheckItemSelected())
                {
                    if (this.personeelService == null)
                    {
                        ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                        MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
                        menuItemService.DeleteMenuItem(selectedMenuItem);
                        FillMenuListView((MenuType)selectedMenuItem.MenuId);
                    }
                    else
                    {
                        ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                        Personeel selectedEmployee = (Personeel)selectedLsvItem.Tag;
                        personeelService.RemovePersoneel(selectedEmployee);
                        FillEmployeeListView((Functie)selectedEmployee.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecteer een item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                this.form.SwitchPanels(new UserControlNewObject((MenuType)btnAddNew.Tag));
            }
            else
            {
                this.form.SwitchPanels(new UserControlNewObject((Functie)btnAddNew.Tag));
            }

        }
        private bool CheckItemSelected()
        {
            if (lsvDatabaseItems.SelectedItems.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
