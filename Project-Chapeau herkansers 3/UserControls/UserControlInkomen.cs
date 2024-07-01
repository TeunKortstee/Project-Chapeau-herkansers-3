using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlInkomen : UserControl
    {
        const bool betaald = true;

        private Form1 form;
        private BetalingService betalingService;

        public UserControlInkomen()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.betalingService = new BetalingService();
            //FillSalesListView();
        }

        #region ListView
        //private void FillSalesListView()
        //{
        //    double totaleInkomens = 0;
        //    SetListViewColumns();

        //    foreach (Betaling betaling in betalingService.GetBetalingen(betaald))
        //    {
        //        ListViewItem item = DisplayBetalingen(betaling);
        //        lsvPaidBills.Items.Add(item);
        //        totaleInkomens += betaling.Bedrag;
        //    }
        //    lblTotalIncome.Text += $"€ {totaleInkomens:00.00}";
        //}
        #endregion
        private void SetListViewColumns()
        {
            lsvPaidBills.Clear();

            lsvPaidBills.Columns.Add("Methode", 100);
            lsvPaidBills.Columns.Add("Bedrag", 100);
            lsvPaidBills.Columns.Add("Fooi", 100);
        }
        private ListViewItem DisplayBetalingen(Betaling betaling)
        {
            ListViewItem item = new ListViewItem(betaling.Methode.ToString());
            item.SubItems.Add($"€ {betaling.Bedrag:00.00}");
            item.SubItems.Add($"€ {betaling.Fooi:00.00}");
            return item;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }
    }
}
