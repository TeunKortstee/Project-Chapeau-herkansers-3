﻿using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlMenu : UserControl
    {
        private Form1 form;
        private MenuItemService menuItemService;
        private Menu selectedMenu;
        private MenuItemControl controlMode;
        public UserControlMenu(MenuItemControl controlMode)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.controlMode = controlMode;
            this.menuItemService = new MenuItemService();
            List<Menu> menus = GetAllMenus();
            SetLogic(controlMode, menus);
        }
        private List<Menu> GetAllMenus()
        {
            List<Menu> menus = new List<Menu>();
            try
            {
                menus.Add(CreateMenuObject(MenuType.Lunch));
                menus.Add(CreateMenuObject(MenuType.Diner));
                menus.Add(CreateMenuObject(MenuType.Drank));
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }
            return menus;
        }
        private Menu CreateMenuObject(MenuType menuType)
        {
            Menu menu = menuItemService.GetAllMenuItemsByMenuType(menuType);
            menu.MenuType = menuType;
            return menu;
        }
        #region ControlLogic
        private void SetDefaultMenu(List<Menu> menus)
        {
            Menu lunchMenu = GetMenu((MenuType)btnLunch.Tag, menus);
            SetSelectedMenu(lunchMenu);
            DisplayMenuItemsFromMenu(lunchMenu, this.controlMode);
            RenableMenuButtons(lunchMenu.MenuType);
        }
        private void SetLogic(MenuItemControl controlMode, List<Menu> menus)
        {
            SetButtonTags();
            SetButtonClicks(menus);
            SetSpecificLogic(controlMode);
            SetDefaultMenu(menus);
        }
        private void SetSpecificLogic(MenuItemControl controlMode)
        {
            switch (controlMode)
            {
                case MenuItemControl.Menu:
                    CreateMenuListView((MenuType)btnLunch.Tag);
                    SetFirstFieldText("Menu", "Menu Item");
                    btnAddNewObject.Visible = true;
                    btnRemove.Visible = true;
                    break;
                case MenuItemControl.Voorraad:
                    SetFirstFieldText("Voorraad", "Menu Item");
                    CreateVoorraadListView();
                    break;
                case MenuItemControl.Inkomen:
                    SetFirstFieldText("Inkomen", "Menu Item");
                    CreateInkomenListView();
                    SetElementsVisibleInkomen();
                    break;
            }
        }
        private void SetElementsVisibleInkomen()
        {
            btnAdjust.Visible = false;
            dtpDatumVan.Visible = true;
            dtpDatumTot.Visible = true;
            lblTotalIncome.Visible = true;
        }
        private void SetButtonTags()
        {
            btnLunch.Tag = MenuType.Lunch;
            btnDiner.Tag = MenuType.Diner;
            btnDrank.Tag = MenuType.Drank;
        }
        private void SetButtonClicks(List<Menu> menus)
        {
            btnLunch.Click += (sender, e) => LunchButtonClick(GetMenu((MenuType)btnLunch.Tag, menus));
            btnDiner.Click += (sender, e) => DinerButtonClick(GetMenu((MenuType)btnDiner.Tag, menus));
            btnDrank.Click += (sender, e) => DrankButtonClick(GetMenu((MenuType)btnDrank.Tag, menus));
        }
        private void SetSelectedMenu(Menu menu)
        {
            this.selectedMenu = menu;
        }
        #endregion

        #region DisplayUIElements

        #region ListViews
        private ListViewItem CreateListViewItem(MenuItem menuItem, MenuItemControl controlMode)
        {
            ListViewItem item = new ListViewItem(menuItem.Naam);
            switch (controlMode)
            {
                case MenuItemControl.Menu:
                    item = AddSubItemsMenu(item, menuItem);
                    break;
                case MenuItemControl.Voorraad:
                    item = AddSubItemsVoorraad(item, menuItem);
                    break;
                case MenuItemControl.Inkomen:
                    item = AddSubItemsInkomen(item, menuItem);
                    break;
            }
            return item;
        }
        private void CreateMenuListView(MenuType menuType)
        {
            lsvMenuItems.Clear();

            lsvMenuItems.Columns.Add("Item", 250);
            lsvMenuItems.Columns.Add("Prijs", 60);
            if (menuType == MenuType.Drank)
            {
                lsvMenuItems.Columns.Add("Alcoholisch", 60);
            }
        }
        private void CreateVoorraadListView()
        {
            lsvMenuItems.Clear();

            lsvMenuItems.Columns.Add("Item", 250);
            lsvMenuItems.Columns.Add("In Voorraad", 60);
        }
        private void CreateInkomenListView()
        {
            lsvMenuItems.Clear();

            lsvMenuItems.Columns.Add("Item", 250);
            lsvMenuItems.Columns.Add("Verkocht", 60);
            lsvMenuItems.Columns.Add("Inkomen", 60);
        }
        #endregion

        #region Sorteer Items

        private Menu GetMenu(MenuType menuType, List<Menu> menus)
        {
            Menu chosenMenu = new Menu();
            foreach (Menu menu in menus)
            {
                if (menu.MenuType == menuType)
                {
                    chosenMenu = menu;
                    break;
                }
            }
            return chosenMenu;
        }
        #endregion

        private void DisplayMenuItemsFromMenu(Menu menu, MenuItemControl controlMode)
        {
            double totaleInkomens = 0;
            foreach (MenuItem menuItem in menu.MenuItems)
            {

                ListViewItem item = CreateListViewItem(menuItem, controlMode);
                item.Tag = menuItem;
                lsvMenuItems.Items.Add(item);
                totaleInkomens += menuItem.TotaleInkomen;
            }
            lblTotalIncome.Text = $"Totale Inkomen: € {totaleInkomens:0.00}";
        }
        #region SubItems
        private ListViewItem AddSubItemsMenu(ListViewItem item, MenuItem menuItem)
        {
            item.SubItems.Add($"€ {menuItem.Prijs:0.00}");
            if (IsAlcoholic(menuItem))
            {
                item.SubItems.Add("Ja");
            }
            return item;
        }
        private ListViewItem AddSubItemsVoorraad(ListViewItem item, MenuItem menuItem)
        {
            if (menuItem.Voorraad <= 3)
            {
                item.BackColor = Color.FromArgb(0, 245, 108, 117);
            }
            item.SubItems.Add($"{menuItem.Voorraad}");
            return item;
        }
        private ListViewItem AddSubItemsInkomen(ListViewItem item, MenuItem menuItem)
        {
            menuItem.TotaalVerkocht = GetMenuItemSalesAmount(menuItem);
            item.SubItems.Add($"{menuItem.TotaalVerkocht}");
            item.SubItems.Add($"€ {menuItem.TotaleInkomen:0.00}");
            return item;
        }
        #endregion

        private int GetMenuItemSalesAmount(MenuItem menuItem)
        {
            int totalSales = 0;
            try
            {
                totalSales = menuItemService.GetMenuItemSales(menuItem, dtpDatumVan.Value, dtpDatumTot.Value);
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }
            return totalSales;
        }
        private bool IsAlcoholic(MenuItem menuItem)
        {
            if (menuItem.MenuType == MenuType.Drank && menuItem.IsAlcoholisch)
            {
                return true;
            }
            return false;
        }

        private void SetFirstFieldText(string title, string objectType)
        {
            lblTitel.Text = title;
            btnAddNewObject.Text = $"{objectType} toevoegen";
        }

        #endregion

        #region Top Buttons
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlItemEdit(new MenuItem(), false, controlMode));
        }
        private void LunchButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnLunch);
        }
        private void DinerButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnDiner);
        }
        private void DrankButtonEnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btnDrank);
        }
        private void LunchButtonClick(Menu lunchMenu)
        {
            SetSpecificLogic(this.controlMode);
            SetSelectedMenu(lunchMenu);
            DisplayMenuItemsFromMenu(lunchMenu, this.controlMode);
            RenableMenuButtons(lunchMenu.MenuType);
        }
        private void DinerButtonClick(Menu dinerMenu)
        {
            SetSpecificLogic(this.controlMode);
            SetSelectedMenu(dinerMenu);
            DisplayMenuItemsFromMenu(dinerMenu, this.controlMode);
            RenableMenuButtons(dinerMenu.MenuType);
        }
        private void DrankButtonClick(Menu drankMenu)
        {
            SetSpecificLogic(this.controlMode);
            SetSelectedMenu(drankMenu);
            DisplayMenuItemsFromMenu(drankMenu, this.controlMode);
            RenableMenuButtons(drankMenu.MenuType);
        }
        #endregion

        #region ButtonStates
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
        }
        private void SetButtonStates(bool lunch, bool diner, bool drank)
        {
            btnLunch.Enabled = lunch;
            btnDiner.Enabled = diner;
            btnDrank.Enabled = drank;
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
            ListViewItem selectedLsvItem = lsvMenuItems.SelectedItems[0];
            AdjustSelectedItem((MenuItem)selectedLsvItem.Tag);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsSelected())
                {
                    return;
                }
                ListViewItem selectedLsvItem = lsvMenuItems.SelectedItems[0];
                DeleteSelectedItem((MenuItem)selectedLsvItem.Tag);
                lsvMenuItems.Items.Remove(selectedLsvItem);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
        }
        private void DatumValueChanged(object sender, EventArgs e)
        {
            DisplayMenuItemsFromMenu(this.selectedMenu, this.controlMode);
        }
        #endregion

        #region ListViewItem
        private void DeleteSelectedItem(MenuItem menuItem)
        {
            if (!IsConfirmed())
            {
                return;
            }
            RemoveMenuItem(menuItem);
            this.selectedMenu.MenuItems.Remove(menuItem);
        }
        private void AdjustSelectedItem(MenuItem menuItem)
        {
            this.form.SwitchPanels(new UserControlItemEdit(menuItem, true, controlMode));
        }
        private void RemoveMenuItem(MenuItem selectedMenuItem)
        {
            try
            {
                menuItemService.SoftDeleteMenuItem(selectedMenuItem);
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis");
            }

        }
        private bool IsConfirmed()
        {
            DialogResult confirmResult = MessageBox.Show("Weet u zeker dat u dit item wilt verwijderen?", "Ja of Nee", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        #endregion

        private bool IsSelected()
        {
            if (lsvMenuItems.SelectedItems.Count > 0)
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
