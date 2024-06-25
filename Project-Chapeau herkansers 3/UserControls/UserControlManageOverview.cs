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
            btnOption1.Tag = MenuType.Lunch;
            btnOption1.Text = MenuType.Lunch.ToString();
            btnOption2.Tag = MenuType.Diner;
            btnOption2.Text = MenuType.Diner.ToString();
            btnOption3.Tag = MenuType.Drank;
            btnOption3.Text = MenuType.Drank.ToString();
        }
        private void RenableMenuButtons(MenuType menuType)
        {
            switch (menuType)
            {
                case MenuType.Lunch:
                    btnOption1.Enabled = false;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = true;
                    break;
                case MenuType.Diner:
                    btnOption1.Enabled = true;
                    btnOption2.Enabled = false;
                    btnOption3.Enabled = true;
                    break;
                case MenuType.Drank:
                    btnOption1.Enabled = true;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = false;
                    break;
            }
            btnAddNewObject.Tag = menuType;
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
            btnOption1.Tag = Functie.Serveerder;
            btnOption1.Text = Functie.Serveerder.ToString();
            btnOption2.Tag = Functie.Keuken;
            btnOption2.Text = Functie.Keuken.ToString();
            btnOption3.Tag = Functie.Bar;
            btnOption3.Text = Functie.Bar.ToString();
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
                    btnOption1.Enabled = false;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = true;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Keuken:
                    btnOption1.Enabled = true;
                    btnOption2.Enabled = false;
                    btnOption3.Enabled = true;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Bar:
                    btnOption1.Enabled = true;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = false;
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Manager:
                    btnOption1.Enabled = true;
                    btnOption2.Enabled = true;
                    btnOption3.Enabled = true;
                    chkManagers.CheckState = CheckState.Checked;
                    break;
            }
            btnAddNewObject.Tag = functie;
        }
        #endregion
        #endregion
        private void SetObjectText(string objectType)
        {
            btnAddNewObject.Text = $"{objectType} toevoegen";
        }

        #endregion

        #region Top Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            switch (btnOption1.Tag)
            {
                case MenuType:
                    FillMenuListView((MenuType)btnOption1.Tag);
                    RenableMenuButtons((MenuType)btnOption1.Tag);
                    break;
                case Functie:
                    FillEmployeeListView((Functie)btnOption1.Tag);
                    RenableEmployeeButtons((Functie)btnOption1.Tag);
                    break;
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
            }
        }
        private void btn1_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            switch (btnOption2.Tag)
            {
                case MenuType:
                    FillMenuListView((MenuType)btnOption2.Tag);
                    RenableMenuButtons((MenuType)btnOption2.Tag);
                    break;
                case Functie:
                    FillEmployeeListView((Functie)btnOption2.Tag);
                    RenableEmployeeButtons((Functie)btnOption2.Tag);
                    break;
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
            }
        }
        private void btn2_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            switch (btnOption3.Tag)
            {
                case MenuType:
                    FillMenuListView((MenuType)btnOption3.Tag);
                    RenableMenuButtons((MenuType)btnOption3.Tag);
                    break;
                case Functie:
                    FillEmployeeListView((Functie)btnOption3.Tag);
                    RenableEmployeeButtons((Functie)btnOption3.Tag);
                    break;
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
            }
        }
        private void btn3_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption3);
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
            if (int.Parse(item.SubItems[1].Text) <= weinigInVoorraad)
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
                if (selectedLsvItem == null)
                {
                    DisplayErrorMessage("Selecteer een item uit de lijst");
                }
                else
                {
                    MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
                    this.form.SwitchPanels(new UserControlAdjustStock(selectedMenuItem));
                }
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
                        MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
                        RemoveMenuItem(selectedMenuItem);
                        FillMenuListView((MenuType)selectedMenuItem.MenuId);
                        break;
                    case Personeel:
                        Personeel selectedPersoneel = (Personeel)selectedLsvItem.Tag;
                        RemovePersoneel(selectedPersoneel);
                        FillEmployeeListView((Functie)selectedPersoneel.Id);
                        break;
                    default:
                        DisplayErrorMessage("Selecteer een item uit de lijst");
                        break;
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage("Er ging iets mis met de database");
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            switch (btnAddNewObject.Tag)
            {
                case MenuType:
                    this.form.SwitchPanels(new UserControlNewObject((MenuType)btnAddNewObject.Tag));
                    break;
                case Functie:
                    this.form.SwitchPanels(new UserControlNewObject((Functie)btnAddNewObject.Tag));
                    break;
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
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
            menuItemService.SoftDeleteMenuItem(selectedMenuItem);
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
