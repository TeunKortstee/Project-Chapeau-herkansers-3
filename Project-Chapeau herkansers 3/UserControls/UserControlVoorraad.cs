using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlVoorraad : UserControl
    {
        const int weinigInVoorraad = 3;

        private Form1 form;
        private MenuItemService menuItemService;
        public UserControlVoorraad(MenuType menuType)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.menuItemService = new MenuItemService();
            FillMenuListView(menuType);
        }
        private void FillMenuListView(MenuType menuType)
        {
            lsvStockItems.Clear();

            lsvStockItems.Columns.Add("Item", 250);
            lsvStockItems.Columns.Add("In Voorraad", 60);

            GetMenuItems(menuType);
        }
        private void GetMenuItems(MenuType menuType)
        {
            try
            {
                foreach (MenuItem menuItem in menuItemService.GetMenuItems(menuType))
                {
                    DisplayMenuItems(menuItem);
                }
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
        }
        private void DisplayMenuItems(MenuItem menuItem)
        {
            ListViewItem item = new ListViewItem(menuItem.Naam);
            item.SubItems.Add(menuItem.Voorraad.ToString());
            item.Tag = menuItem;
            CheckLowStock(item);
        }

        private void btnAdjustStock_Click(object sender, EventArgs e)
        {
            if (!IsSelected())
            {
                return;
            }
            ListViewItem selectedLsvItem = lsvStockItems.SelectedItems[0];
            this.form.SwitchPanels(new UserControlVoorraadEdit((MenuItem)selectedLsvItem.Tag));
        }
        private bool IsSelected()
        {
            if (lsvStockItems.SelectedItems.Count > 0)
            {
                return true;
            }
            DisplayErrorMessage("Selecteer een item uit de lijst");
            return false;
        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            FillMenuListView(MenuType.Lunch);
        }
        private void btnOption2_Click(object sender, EventArgs e)
        {
            FillMenuListView(MenuType.Diner);
        }
        private void btnOption3_Click(object sender, EventArgs e)
        {
            FillMenuListView(MenuType.Drank);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }
        private void CheckLowStock(ListViewItem item)
        {
            if (int.TryParse(item.SubItems[1].Text, out int voorraad) && voorraad <= weinigInVoorraad)
            {
                item.BackColor = Color.FromArgb(0, 245, 108, 117);
                lsvStockItems.Items.Insert(0, item);
            }
            else
            {
                lsvStockItems.Items.Add(item);
            }
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorStock.Visible = true;
            lblErrorStock.Text = errorMessage;
        }
    }
}
