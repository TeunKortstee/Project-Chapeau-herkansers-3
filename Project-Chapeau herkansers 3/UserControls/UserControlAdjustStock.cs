using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlAdjustStock : UserControl
    {
        private Form1 form;
        private MenuItemService menuItemService;
        private MenuItem selectedMenuItem;
        public UserControlAdjustStock(Form1 form, MenuItem selectedMenuItem)
        {
            InitializeComponent();
            this.form = form;
            this.menuItemService = new MenuItemService();
            this.selectedMenuItem = selectedMenuItem;
            DisplayUIElements(this.selectedMenuItem);
        }
        private void DisplayUIElements(MenuItem selectedMenuItem)
        {
            picName.Location = new Point(30, 265);
            lblStock.Location = new Point(28, 187);
            btnAdd.Location = new Point(278, 283);
            btnSubtract.Location = new Point(211, 283);
            lblNewStock.Location = new Point(46, 285);
            txtStock.Location = new Point(241, 283);
            txtStock.Text = selectedMenuItem.Voorraad.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.selectedMenuItem.Voorraad = int.Parse(txtStock.Text);
                menuItemService.UpdateMenuItemStock(this.selectedMenuItem);
                ReturnToOverview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vul een getal in.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReturnToOverview();
        }
        private void ReturnToOverview()
        {
            Form1.Instance.SwitchPanels(new UserControlOverview(form, (MenuType)this.selectedMenuItem.MenuId));
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtStock.Text = (int.Parse(txtStock.Text) + 1).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtStock.Text = (int.Parse(txtStock.Text) - 1).ToString();
        }
        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            int newStock;
            if (txtStock.Text.Length > 0)
            {
                if (int.TryParse(txtStock.Text, out newStock))
                {
                    CheckStockMinAndMax(newStock);
                }
            }
        }
        private void CheckStockMinAndMax(int newStock)
        {
            int minimum = 0;
            int temporaryHardcodedMaximum = 100;
            if (newStock <= minimum)
            {
                btnSubtract.Enabled = false;
                txtStock.Text = minimum.ToString();
            }
            else if (newStock > minimum && newStock < temporaryHardcodedMaximum)
            {
                btnSubtract.Enabled = true;
                btnAdd.Enabled = true;
                txtStock.Text = newStock.ToString();
            }
            else
            {
                btnAdd.Enabled = false;
                txtStock.Text = temporaryHardcodedMaximum.ToString();
            }
        }
    }
}
