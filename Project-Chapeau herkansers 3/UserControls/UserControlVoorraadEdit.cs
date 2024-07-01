using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlVoorraadEdit : UserControl
    {
        private Form1 form;
        private MenuItemService menuItemService;
        private MenuItem selectedMenuItem;
        public UserControlVoorraadEdit(MenuItem selectedMenuItem)
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.menuItemService = new MenuItemService();
            this.selectedMenuItem = selectedMenuItem;
            DisplayUIElements(this.selectedMenuItem);
        }
        private void DisplayUIElements(MenuItem selectedMenuItem)
        {
            txtStock.Text = selectedMenuItem.Voorraad.ToString();
            CheckStockMinAndMax(selectedMenuItem.Voorraad);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    DisplayErrorMessage(InvalidInput());
                    return;
                }
                this.selectedMenuItem.Voorraad = stock;
                menuItemService.UpdateMenuItemStock(this.selectedMenuItem);
                ReturnToOverview(this.selectedMenuItem.MenuType);
            }
            catch (Exception)
            {
                DisplayErrorMessage("Er ging iets mis bij de database");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview(this.selectedMenuItem.MenuType);
        }
        private void ReturnToOverview(MenuType menuType)
        {
            form.SwitchPanels(new UserControlVoorraad(menuType));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateStock(1);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            UpdateStock(-1);
        }
        private void UpdateStock(int change)
        {
            if (!int.TryParse(txtStock.Text, out int stock))
            {
                DisplayErrorMessage(InvalidInput());
                return;
            }
            int newStock = stock + change;
            CheckStockMinAndMax(newStock);
        }
        private void CheckStockMinAndMax(int newStock)
        {
            int minimum = 0;

            if (newStock <= minimum)
            {
                btnSubtract.Enabled = false;
                txtStock.Text = minimum.ToString();
            }
            else
            {
                btnSubtract.Enabled = true;
                btnAdd.Enabled = true;
                txtStock.Text = newStock.ToString();
            }
        }
        #region Errors
        private string InvalidInput()
        {
            return "Vul een geldig getal in";
        }
        private void DisplayErrorMessage(string errorMessage)
        {
            lblErrorVoorraad.Visible = true;
            lblErrorVoorraad.Text = errorMessage;
        }
        #endregion
    }
}
