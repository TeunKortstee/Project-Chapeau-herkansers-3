﻿using Model;
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

        public UserControlSalesOverview()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.rekeningService = new RekeningService();
            //DisplaySalesElements(menuType);
        }
        #region DisplayUIElements

        #region Rekeningen
        private void DisplaySalesElements(MenuType menuType)
        {
            lblOverview.Text = "Menu";
            FillSalesListView(menuType);
        }
        #endregion


        #endregion

        #region ListView
        private void FillSalesListView(MenuType menuType)
        {
            lsvPaidBills.Clear();

            lsvPaidBills.Columns.Add("Id", 60);
            lsvPaidBills.Columns.Add("Methode", 250);
            lsvPaidBills.Columns.Add("Bedrag", 60);
            lsvPaidBills.Columns.Add("Fooi", 60);


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
        #endregion

        #region Top Buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            FillSalesListView((MenuType)btn1.Tag);
            RenableMenuButtons((MenuType)btn1.Tag);
        }
        private void btn1_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            FillSalesListView((MenuType)btn2.Tag);
            RenableMenuButtons((MenuType)btn2.Tag);
        }
        private void btn2_EnabledChanged(object sender, EventArgs e)
        {
            SetEnableColor(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            FillSalesListView((MenuType)btn3.Tag);
            RenableMenuButtons((MenuType)btn3.Tag);
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
            this.form.SwitchPanels(new UserControlManager());
        }
    }
}
