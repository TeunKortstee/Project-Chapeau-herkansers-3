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
        private BetalingService betalingService;

        public UserControlSalesOverview()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.betalingService = new BetalingService();
            FillSalesListView();
        }

        #region ListView
        private void FillSalesListView()
        {
            double totaleInkomens = 0;
            lsvPaidBills.Clear();

            lsvPaidBills.Columns.Add("Id", 60);
            lsvPaidBills.Columns.Add("Methode", 250);
            lsvPaidBills.Columns.Add("Bedrag", 60);
            lsvPaidBills.Columns.Add("Fooi", 60);


            List<Betaling> betaaldeRekeningen = betalingService.GetBetalingen(betaald);
            foreach (Betaling betaling in betaaldeRekeningen)
            {
                ListViewItem item = new ListViewItem(betaling.BetalingId.ToString());
                item.SubItems.Add(betaling.Methode.ToString());
                item.SubItems.Add(betaling.Bedrag.ToString());
                item.SubItems.Add(betaling.Fooi.ToString());
                lsvPaidBills.Items.Add(item);
                totaleInkomens += betaling.Bedrag;
            }
            lblTotalIncome.Text += $"{Math.Round(totaleInkomens, 2):00.00}";
        }
        #endregion

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }
    }
}
