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
    public partial class UserControlSalesOverview : UserControl
    {
        const bool betaald = true;

        private Form1 form;
        private RekeningService rekeningService;
        private PersoneelService? personeelService;

        public UserControlSalesOverview(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = null;
            this.rekeningService = new RekeningService();
            DisplayMenuElements();
        }
        #region DisplayUIElements

        #region Rekeningen
        private void DisplayMenuElements()
        {
            lblTotalIncome.Text = "Totaal: "
            btn1.Text = MenuType.Lunch.ToString();
            btn2.Text = MenuType.Diner.ToString();
            btn3.Text = MenuType.Drank.ToString();
            DisplayMenuButtons(MenuType.Lunch);
            FillMenuListView(MenuType.Lunch);
        }
        #region Buttons - Rekeningen
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
        }
        #endregion
        #endregion


        #endregion

        #region ListView
        private void FillMenuListView(MenuType menuType)
        {
            lsvDatabaseItems.Clear();

            lsvDatabaseItems.Columns.Add("Id", 60);
            lsvDatabaseItems.Columns.Add("Item", 250);
            lsvDatabaseItems.Columns.Add("In Voorraad", 60);


            List<Rekening> betaaldeRekeningen = rekeningService.GetBetaaldeRekeningen(betaald);
            foreach (Rekening rekening in betaaldeRekeningen)
            {
                //ListViewItem item = new ListViewItem(rekening.RekeningId.ToString());
                //item.SubItems.Add(menuItem.Naam);
                //item.SubItems.Add(menuItem.Voorraad.ToString());
                //item.Tag = menuItem;
                //lsvDatabaseItems.Items.Add(item);
            }
        }
        private void FillEmployeeListView(Functie functie)
        {
            lsvDatabaseItems.Columns.Add("Naam", 100);
            lsvDatabaseItems.Columns.Add("Functie", 150);

            List<Personeel> personeel = personeelService.GetAllPersoneel();
            foreach (Personeel werknemer in personeel)
            {
                ListViewItem item = new ListViewItem(werknemer.VoorNaam);
                item.SubItems.Add(werknemer.Functie.ToString());
                item.Tag = werknemer;
                lsvDatabaseItems.Items.Add(item);
            }

        }
        #endregion

        #region Top Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.personeelService == null)
            {
                FillMenuListView(MenuType.Lunch);
                RenableMenuButtons(MenuType.Lunch);
            }
            else
            {
                FillEmployeeListView((Functie)3);
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
                FillMenuListView(MenuType.Diner);
                RenableMenuButtons(MenuType.Diner);
            }
            else
            {
                FillEmployeeListView((Functie)3);
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
                FillMenuListView(MenuType.Drank);
                RenableMenuButtons(MenuType.Drank);
            }
            else
            {
                FillEmployeeListView((Functie)3);
            }
        }
        private void btn3_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn3);
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
            this.form.Switchpanels(new UserControlManager(form));
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsvDatabaseItems.SelectedItems.Count > 0)
                {
                    ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                    MenuItem selecteMenuItem = (MenuItem)selectedLsvItem.Tag;
                    this.form.Switchpanels(new UserControlAdjustStock(form, selecteMenuItem));
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
                if (lsvDatabaseItems.SelectedItems.Count > 0)
                {
                    ListViewItem selectedLsvItem = lsvDatabaseItems.SelectedItems[0];
                    MenuItem selectedMenuItem = (MenuItem)selectedLsvItem.Tag;
                    menuItemService.DeleteMenuItem(selectedMenuItem);
                    FillMenuListView((MenuType)selectedMenuItem.MenuId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selecteer een item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
