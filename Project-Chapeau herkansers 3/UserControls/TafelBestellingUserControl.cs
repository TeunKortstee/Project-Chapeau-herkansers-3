using Model;
using Service;

namespace Project_Chapeau_herkansers_3
{
    public partial class TafelBestellingUserControl : UserControl
    {
        private Tafel tafel;
        public TafelBestellingUserControl(Tafel tafel)
        {
            this.tafel = tafel;
            InitializeComponent();
            LaadComboBox();
            LaadListView(LaadBestelling(checkComboBox()));
        }
        private void LaadListView(List<Bestelling> bestellingen)
        {
            BesteldeItemsListView.Items.Clear();
            foreach (Bestelling bestelling in bestellingen)
            {
                foreach (BesteldeItem item in bestelling.BesteldeItems)
                {
                    TimeSpan wachtTijd = DateTime.Now - item.InstuurTijd;
                    string wachtTijdString = string.Format("{0:%h}h {0:%m}m {0:%s}s", wachtTijd);

                    ListViewItem listViewItem = new ListViewItem(item.menuItem.Naam);
                    listViewItem.SubItems.Add(wachtTijdString);
                    listViewItem.SubItems.Add(bestelling.status.ToString());
                    listViewItem.SubItems.Add(bestelling.bestellingId.ToString());
                    listViewItem.Tag = bestelling;
                    BesteldeItemsListView.Items.Add(listViewItem);
                }
            }
        }

        private void LaadComboBox()
        {
            BereiderBox.Items.Add("Eten");
            BereiderBox.Items.Add("Drinken");
            BereiderBox.SelectedIndex = 0;
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {
            GaTerug();
        }

        private void StuurTerugBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BestellingOpslaan((Bestelling)BesteldeItemsListView.SelectedItems[0].Tag, checkComboBox(), GerechtsStatus.InPreparation);
                GaTerug();
            }
            catch (Exception)
            {
                ErrorLbl.Text = $"Deze bestelling is nog niet afgerond door de {checkComboBox()}";
            }
        }

        private void AfrondBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BestellingOpslaan((Bestelling)BesteldeItemsListView.SelectedItems[0].Tag, checkComboBox(), GerechtsStatus.Served);
                InkomenService inkomenService = new InkomenService();
                inkomenService.UpdateInkomen(((Bestelling)BesteldeItemsListView.SelectedItems[0].Tag).BestellingItems);
                GaTerug();
            }
            catch (Exception)
            {
                ErrorLbl.Text = $"Deze bestelling is nog niet afgerond door de {checkComboBox()}";
            }
        }


        private void BereiderBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadListView(LaadBestelling(checkComboBox()));
        }
        private string checkComboBox()
        {
            switch (BereiderBox.SelectedIndex)
            {
                case 0:
                    return "Keuken";
                default:
                    return "Bar";

            }
        }

        private void GaTerug()
        {
            Form1 form = Form1.Instance;
            form.SwitchPanels(new TafelStatusUI(tafel));
        }

        private List<Bestelling> LaadBestelling(string ItemBereider)
        {
            ItemBereiderService service = new ItemBereiderService();
            return service.GetTafelBestelling(tafel, ItemBereider);
        }

        private void BestellingOpslaan(Bestelling bestelling, string ItemBereider, GerechtsStatus status)
        {
            if (bestelling.status == GerechtsStatus.Prepared)
            {
                bestelling.status = status;
                ItemBereiderService service = new ItemBereiderService();
                service.ChangeStatus(bestelling, ItemBereider);

            }
            else
            {
                throw new Exception();
            }

        }
    }
}
