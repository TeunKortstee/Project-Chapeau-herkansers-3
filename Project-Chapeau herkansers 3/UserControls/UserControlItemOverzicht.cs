using Model;
using Service;
using System.Collections.Generic;
using System.Diagnostics;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlItemOverzicht : UserControl
    {
        private Form1 form;
        private List<MenuItem> menu;
        private MenuItemControl controlMode;
        public UserControlItemOverzicht(MenuItemControl controlMode)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.controlMode = controlMode;
            SetLogic(controlMode);
            this.menu = GetMenuItemsFromDao();
        }
        #region ControlLogic
        private void SetLogic(MenuItemControl controlMode)
        {
            SetButtons();
            switch (controlMode)
            {
                case MenuItemControl.Menu:
                    SetObjectText("Menu", "Menu Item");
                    CreateMenuListView((BereidingsPlek)btnKeuken.Tag);
                    break;
                case MenuItemControl.Voorraad:
                    SetObjectText("Voorraad", "Menu Item");
                    CreateVoorraadListView((BereidingsPlek)btnKeuken.Tag);
                    break;
                case MenuItemControl.Inkomen:
                    SetObjectText("Inkomen", "Menu Item");
                    CreateInkomenListView((BereidingsPlek)btnKeuken.Tag);
                    break;
            }
        }
        private void SetButtons()
        {
            btnKeuken.Tag = BereidingsPlek.Keuken;
            btnBar.Tag = BereidingsPlek.Bar;
        }
        #endregion
        private List<MenuItem> GetMenuItemsFromDao()
        {
            List<MenuItem> menu = new List<MenuItem>();
            try
            {
                MenuItemService menuItemService = new MenuItemService();
                menu = menuItemService.GetMenuItems();
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
            return menu;
        }
        #region DisplayUIElements

        #region ListViews
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
        private void CreateVoorraadListView(BereidingsPlek bereidingsPlek)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("Prijs", 60);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);
        }
        private void CreateInkomenListView(BereidingsPlek bereidingsPlek)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("Prijs", 60);
            lsvDatabaseItems.Columns.Add("Verkocht", 60);
        }
        #endregion

        private List<MenuItem> GetMenuItems(BereidingsPlek bereidingsPlek)
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
            return list;  
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
        private void DisplayMenuItems(List<MenuItem> menuItems, MenuItemControl controlMode)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                ListViewItem item = CreateListViewItem(menuItem, controlMode);
                item.Tag = menuItem;
                lsvDatabaseItems.Items.Add(item);
            }
        }
        private ListViewItem CreateListViewItem(MenuItem menuItem, MenuItemControl controlMode)
        {
            ListViewItem item = new ListViewItem(menuItem.Naam);
            switch (controlMode)
            {
                case MenuItemControl.Menu:
                    item.SubItems.Add($"€ {menuItem.Prijs:0.00}");
                    if (IsAlcoholic(menuItem))
                    {
                        item.SubItems.Add("Ja");
                    }
                    break;
                case MenuItemControl.Voorraad:
                    item.SubItems.Add($"€ {menuItem.Voorraad}");
                    break;
                case MenuItemControl.Inkomen:
                    SetObjectText("Inkomen", "Menu Item");
                    CreateInkomenListView((BereidingsPlek)btnKeuken.Tag);
                    break;
            }
            return item;
        }
        private bool IsAlcoholic(MenuItem menuItem)
        {
            if (menuItem.MenuType == MenuType.Drank && menuItem.IsAlcoholisch)
            {
                return true;
            }
            return false;
        }

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
                default:
                    DisplayErrorMessage("Er ging iets mis");
                    break;
            }
        }
        private void BarButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnBar);
        }
        private void KitchenButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnKeuken);
        }
        private void BarButtonClick(object sender, EventArgs e)
        {
            CreateMenuListView((BereidingsPlek)btnBar.Tag);
            List<MenuItem> barList = GetMenuItems((BereidingsPlek)btnBar.Tag);
            DisplayMenuItems(barList, this.controlMode);
        }
        private void KitchenButtonClick(object sender, EventArgs e)
        {
            CreateMenuListView((BereidingsPlek)btnKeuken.Tag);
            List<MenuItem> keukenList = GetMenuItems((BereidingsPlek)btnKeuken.Tag);
            DisplayMenuItems(keukenList, this.controlMode);
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
            RemoveMenuItem((MenuItem)selectedLsvItem.Tag);
        }
        private void AdjustSelectedItem(ListViewItem selectedLsvItem)
        {
            this.form.SwitchPanels(new UserControlItemEdit((MenuItem)selectedLsvItem.Tag));
        }
        private void RemoveMenuItem(MenuItem selectedMenuItem)
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.SoftDeleteMenuItem(selectedMenuItem);
            //FillMenuListView(selectedMenuItem.MenuType);
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
