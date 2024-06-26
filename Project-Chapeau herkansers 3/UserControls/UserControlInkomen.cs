using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlInkomen : UserControl
    {
        private Form1 form;
        private InkomenService inkomenService;

        public UserControlInkomen()
        {
            InitializeComponent();
            this.form = Form1.Instance;
            this.inkomenService = new InkomenService();
            FillSalesListView(BereidingsPlek.Keuken);
        }

        #region ListView
        private void FillSalesListView(BereidingsPlek bereidingsPlek)
        {
            double totaleInkomens = 0;
            SetListViewColumns();

            foreach (Inkomen inkomen in inkomenService.GetInkomens(bereidingsPlek))
            {
                ListViewItem item = DisplayInkomen(inkomen);
                lsvPaidBills.Items.Add(item);
                totaleInkomens += inkomen.TotaleInkomen;
            }
            lblTotalIncome.Text = $"{bereidingsPlek}: € {totaleInkomens:0.00}";
        }
        #endregion
        private void SetListViewColumns()
        {
            lsvPaidBills.Clear();

            lsvPaidBills.Columns.Add("Item", 150);
            lsvPaidBills.Columns.Add("Totale Inkomens", 150);
            lsvPaidBills.Columns.Add("Hoeveelheid", 150);
        }
        private ListViewItem DisplayInkomen(Inkomen inkomen)
        {
            ListViewItem item = new ListViewItem(inkomen.MenuItem.Naam);
            item.SubItems.Add($"€ {inkomen.TotaleInkomen:0.00}");
            item.SubItems.Add($"{inkomen.Hoeveelheid}");
            return item;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.form.SwitchPanels(new UserControlManager());
        }

        private void btnKeuken_Click(object sender, EventArgs e)
        {
            FillSalesListView(BereidingsPlek.Keuken);
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            FillSalesListView(BereidingsPlek.Bar);
        }
    }
}
