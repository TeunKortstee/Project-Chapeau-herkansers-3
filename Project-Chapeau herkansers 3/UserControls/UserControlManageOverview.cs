using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlManageOverview : UserControl
    {
        const int weinigInVoorraad = 3;
        
        private Form1 form;
        public UserControlManageOverview(Functie functie)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayEmployeeElements(functie);
        }
        public UserControlManageOverview(MenuType menu)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            DisplayMenuElements(menu);
        }
        #region DisplayUIElements

        #region MenuItem
        private void DisplayMenuElements(MenuType menuType)
        {
            lblOverview.Text = "Menu";
            SetObjectText("Menu Item");
            DisplayMenuButtons();
            RenableMenuButtons(menuType);
            FillMenuListView(menuType);
        }
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);

            MenuItemService menuItemService = new MenuItemService();
            List<MenuItem> selectedMenu = menuItemService.GetMenuItemsByMenu(menuType);
            foreach (MenuItem menuItem in selectedMenu)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Voorraad.ToString());
                item.Tag = menuItem;
                CheckLowStock(item);
            }
        }
        #region Buttons - MenuItem
        private void DisplayMenuButtons()
        {
            btn1.Tag = MenuType.Lunch;
            btn1.Text = MenuType.Lunch.ToString();
            btn2.Tag = MenuType.Diner;
            btn2.Text = MenuType.Diner.ToString();
            btn3.Tag = MenuType.Drank;
            btn3.Text = MenuType.Drank.ToString();
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
            DisplayEmployeeButtons();
            RenableEmployeeButtons(functie);
            FillEmployeeListView(functie);
        }
        private void FillEmployeeListView(Functie functie)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            PersoneelService personeelService = new PersoneelService();
            List<Personeel> personeel = personeelService.GetPersoneelByFunctie(functie);
            foreach (Personeel werknemer in personeel)
            {
                ListViewItem item = new ListViewItem(werknemer.AchterNaam);
                item.SubItems.Add(werknemer.Functie.ToString());
                item.Tag = werknemer;
                lsvDatabaseItems.Items.Add(item);
            }
        }
        #region Buttons - Employee
        private void DisplayEmployeeButtons()
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

        private void CheckLowStock(ListViewItem item)
        {
            if (int.Parse(item.SubItems[2].Text) <= weinigInVoorraad)
            {
                item.BackColor = Color.FromArgb(0, 245, 108, 117);
                lsvDatabaseItems.Items.Insert(0, item);
            }
            else
            {
                lsvDatabaseItems.Items.Add(item);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedLsvItem = GetItemSelected();
                if (selectedLsvItem != null)
                {

                }
                MenuItem selecteMenuItem = (MenuItem)selectedLsvItem.Tag;
                this.form.SwitchPanels(new UserControlAdjustStock(selecteMenuItem));
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedLsvItem = GetItemSelected();
                switch (selectedLsvItem.Tag)
                {
                    case MenuItem:
                        RemoveMenuItem((MenuItem)selectedLsvItem.Tag);
                        break;
                    case Personeel:
                        RemovePersoneel((Personeel)selectedLsvItem.Tag);
                        break;
                    default:
                        DisplayErrorMessage("Selecteer een item uit de lijst");
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                switch (btnAddNew.Tag)
                {
                    case MenuType:
                        this.form.SwitchPanels(new UserControlNewObject((MenuType)btnAddNew.Tag));
                        break;
                    case Functie:
                        this.form.SwitchPanels(new UserControlNewObject((Functie)btnAddNew.Tag));
                        break;
                    default:
                        throw new Exception("Er ging iets mis");
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void RemovePersoneel(Personeel selectedEmployee)
        {
            PersoneelService personeelService = new PersoneelService();
            personeelService.RemovePersoneel(selectedEmployee);
            FillEmployeeListView((Functie)selectedEmployee.Id);
        }
        private void RemoveMenuItem(MenuItem selectedMenuItem)
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.DeleteMenuItem(selectedMenuItem);
            FillMenuListView((MenuType)selectedMenuItem.MenuId);
        }
        private ListViewItem GetItemSelected()
        {
            ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
            if (lsvDatabaseItems.SelectedItems.Count > 0)
            {
                return selectedLsvItem;
            }
            return null;
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblError.Text = errorMessage;
        }
    }
}
