using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlItemOverzicht : UserControl
    {
        private Form1 form;
        private MenuItemService menuItemService;
        private List<MenuItem> menu;
        public UserControlItemOverzicht()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.menuItemService = new MenuItemService();
            this.menu = GetMenuItems();
            DisplayMenuElements();
            SetButtonTags();
        }
        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menu = new List<MenuItem>();
            try
            {
                menu = menuItemService.GetMenuItems();
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
            return menu;
        }
        #region DisplayUIElements

        #region MenuItem
        private void SetButtonTags()
        {
            btnKeuken.Tag = BereidingsPlek.Keuken;
            btnBar.Tag = BereidingsPlek.Bar;
        }
        private void DisplayMenuElements()
        {
            SetObjectText("Menu", "Menu Item");
            CreateMenuListView((BereidingsPlek)btnKeuken.Tag);
            GetMenuItems((BereidingsPlek)btnKeuken.Tag);
        }
        private void CreateMenuListView(BereidingsPlek bereidingsPlek)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("Prijs", 60);
            if (bereidingsPlek == BereidingsPlek.Bar)
            {
                lsvDatabaseItems.Columns.Add("Alcoholisch", 60);
            }
        }
        private void GetMenuItems(BereidingsPlek bereidingsPlek)
        {
            List<MenuItem> list = new List<MenuItem>(); 
            switch (bereidingsPlek)
            {
                case BereidingsPlek.Bar:
                    list = GetDrinks();
                    break;
                case BereidingsPlek.Keuken:
                    list = GetFood();
                    break;
            }
            DisplayMenuItems(list);
        }
        private List<MenuItem> GetDrinks()
        {
            List<MenuItem> barList = new List<MenuItem>();
            foreach(MenuItem menuItem in menu)
            {
                if (menuItem.MenuType == MenuType.Drank)
                {
                    barList.Add(menuItem);
                }
            }
            return barList;
        }
        private List<MenuItem> GetFood()
        {
            List<MenuItem> kitchenList = new List<MenuItem>();
            foreach (MenuItem menuItem in menu)
            {
                if (menuItem.MenuType != MenuType.Drank)
                {
                    kitchenList.Add(menuItem);
                }
            }
            return kitchenList;
        }
        private void DisplayMenuItems(List<MenuItem> menuItems)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                DisplayMenuItem(menuItem);
            }
        }
        private void DisplayMenuItem(MenuItem menuItem)
        {
            ListViewItem item = new ListViewItem(menuItem.Naam);
            item.SubItems.Add($"€ {menuItem.Prijs:0.00}");
            if (IsAlcoholic(menuItem))
            {
                item.SubItems.Add("Ja");
            }
            item.Tag = menuItem;
            lsvDatabaseItems.Items.Add(item);
        }
        private bool IsAlcoholic(MenuItem menuItem)
        {
            if (menuItem.MenuType == MenuType.Drank && menuItem.IsAlcoholisch)
            {
                return true;
            }
            return false;
        }
        #endregion

        private void SetObjectText(string title, string objectType)
        {
            lblTitel.Text = title;
            btnAddNewObject.Text = $"{objectType} toevoegen";
        }

        #endregion

        #region Top Buttons
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            switch (btnAddNewObject.Tag)
            {
                case MenuType:
                    this.form.SwitchPanels(new UserControlNieuwItem((MenuType)btnAddNewObject.Tag));
                    break;
                case Functie:
                    this.form.SwitchPanels(new UserControlNieuwItem((Functie)btnAddNewObject.Tag));
                    break;
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
            }
        }
        private void btnOption1_Click(object sender, EventArgs e)
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
        private void btnOption1_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption1);
        }
        private void btnOption2_Click(object sender, EventArgs e)
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
        private void btnOption2_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption2);
        }
        private void btnOption3_Click(object sender, EventArgs e)
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
        private void btnOption3_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnOption3);
        }
        private void chkOption4_Click(object sender, EventArgs e)
        {
            RenableEmployeeButtons((Functie)chkOption4.Tag);
            FillEmployeeListView((Functie)chkOption4.Tag);
        }
        private void SetEnableColor(Button button)
        {
            if (button.Enabled)
            {
                button.BackColor = Color.FromArgb(255, 138, 210, 176);
            }
            else
            {
                button.BackColor = Color.FromArgb(114, 138, 210, 176);
            }
        }
        #endregion

        #region Bottom Buttons

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (!IsSelected())
            {
                return;
            }
            ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
            AdjustSelectedItem(selectedLsvItem);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsSelected())
                {
                    return;
                }
                ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];

                DeleteSelectedItem(selectedLsvItem);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        #endregion

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
            }
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            switch (selectedLsvItem.Tag)
            {
                case MenuItem:
                    this.form.SwitchPanels(new UserControlItemEdit((MenuItem)selectedLsvItem.Tag));
                    break;
                case Personeel:
                    this.form.SwitchPanels(new UserControlItemEdit((Personeel)selectedLsvItem.Tag));
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
            FillMenuListView(selectedMenuItem.MenuType);
        }
        #endregion

        private bool IsSelected()
        {
            if (lsvDatabaseItems.SelectedItems.Count > 0)
            {
                return true;
            }
            DisplayErrorMessage("Selecteer een item uit de lijst");
            return false;
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorOverview.Visible = true;
            lblErrorOverview.Text = errorMessage;
        }
    }
}
