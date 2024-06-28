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
            SetObjectText("Menu", "Menu Item");
            DisplayMenuButtons();
            RenableMenuButtons(menuType);
            FillMenuListView(menuType);
        }
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);

            DisplayMenuItems(menuType);
        }
        private void DisplayMenuItems(MenuType menuType)
        {
            MenuItemService menuItemService = new MenuItemService();
            foreach (MenuItem menuItem in menuItemService.GetMenuItemsByMenu(menuType))
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Voorraad.ToString());
                item.Tag = menuItem;
                CheckLowStock(item);
            }
        }
        #endregion

        #region Employee
        private void DisplayEmployeeElements(Functie functie)
        {
            SetObjectText("Personeel", "Werknemer");
            DisplayEmployeeButtons();
            RenableEmployeeButtons(functie);
            FillEmployeeListView(functie);
        }
        private void FillEmployeeListView(Functie functie)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            DisplayPersoneel(functie);

        }
        private void DisplayPersoneel(Functie functie)
        {
            PersoneelService personeelService = new PersoneelService();
            foreach (Personeel personeel in personeelService.GetPersoneelByFunctie(functie))
            {
                ListViewItem item = new ListViewItem(personeel.AchterNaam);
                item.SubItems.Add(personeel.Functie.ToString());
                item.Tag = personeel;
                lsvDatabaseItems.Items.Add(item);
            }
        }
        #endregion

        #region Buttons - MenuItem
        private void DisplayMenuButtons()
        {
            btnOption1.Tag = MenuType.Lunch;
            btnOption2.Tag = MenuType.Diner;
            btnOption3.Tag = MenuType.Drank;
            SetButtonText(MenuType.Lunch.ToString(), MenuType.Diner.ToString(), MenuType.Drank.ToString());
        }
        private void RenableMenuButtons(MenuType menuType)
        {
            switch (menuType)
            {
                case MenuType.Lunch:
                    SetButtonStates(false, true, true);
                    break;
                case MenuType.Diner:
                    SetButtonStates(true, false, true);
                    break;
                case MenuType.Drank:
                    SetButtonStates(true, true, false);
                    break;
            }
            btnAddNewObject.Tag = menuType;
        }
        #endregion

        #region Buttons - Employee
        private void DisplayEmployeeButtons()
        {
            btnOption1.Tag = Functie.Serveerder;
            btnOption2.Tag = Functie.Keuken;
            btnOption3.Tag = Functie.Bar;
            SetButtonText(Functie.Serveerder.ToString(), Functie.Keuken.ToString(), Functie.Bar.ToString());
            AddButtonChangesForPersoneelManagement();
        }
        private void RenableEmployeeButtons(Functie functie)
        {
            switch (functie)
            {
                case Functie.Serveerder:
                    SetButtonStates(false, true, true);
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Keuken:
                    SetButtonStates(true, false, true);
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Bar:
                    SetButtonStates(true, true, false);
                    chkManagers.CheckState = CheckState.Unchecked;
                    break;
                case Functie.Manager:
                    SetButtonStates(true, true, true);
                    chkManagers.CheckState = CheckState.Checked;
                    break;
            }
            btnAddNewObject.Tag = functie;
        }
        private void AddButtonChangesForPersoneelManagement()
        {
            chkManagers.Visible = true;
            chkManagers.Tag = Functie.Manager;
            btnAdjust.Visible = false;
            btnRemove.Location = new Point(14, 651);
        }
        #endregion

        private void SetObjectText(string title, string objectType)
        {
            lblOverview.Text = title;
            btnAddNewObject.Text = $"{objectType} toevoegen";
        }
        private void SetButtonText(string option1, string option2, string option3)
        {
            btnOption1.Text = option1;
            btnOption2.Text = option2;
            btnOption3.Text = option3;
        }
        private void SetButtonStates(bool option1, bool option2, bool option3)
        {
            btnOption1.Enabled = option1;
            btnOption2.Enabled = option2;
            btnOption3.Enabled = option3;
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
        private void SetEnableColor(Button button)
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
            ListViewItem selectedLsvItem = GetItemSelected();
            if (selectedLsvItem == null)
            {
                DisplayErrorMessage("Selecteer een item uit de lijst");
                return;
            }
            MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
            this.form.SwitchPanels(new UserControlAdjustStock(selectedMenuItem));
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem selectedLsvItem = GetItemSelected();
                if (selectedLsvItem == null)
                {
                    DisplayErrorMessage("Selecteer een item uit de lijst");
                    return;
                }

                DeleteSelectedItem(selectedLsvItem);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        #region DeleteSelectedItem
        private void DeleteSelectedItem(ListViewItem selectedLsvItem)
        {
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
        private void RemovePersoneel(Personeel selectedPersoneel)
        {
            PersoneelService personeelService = new PersoneelService();
            personeelService.RemovePersoneel(selectedPersoneel);
            FillEmployeeListView(selectedPersoneel.Functie);
        }
        private void RemoveMenuItem(MenuItem selectedMenuItem)
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.SoftDeleteMenuItem(selectedMenuItem);
            FillMenuListView(selectedMenuItem.menuType);
        }
        #endregion
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

        private ListViewItem GetItemSelected()
        {
            if (lsvDatabaseItems.SelectedItems.Count > 0)
            {
                return lsvDatabaseItems.SelectedItems[0];
            }
            return null;
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorOverview.Visible = true;
            lblErrorOverview.Text = errorMessage;
        }
    }
}
