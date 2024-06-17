using Model;
using Service;
using System.Xml.Linq;

namespace Project_Chapeau_herkansers_3
{
    public partial class Afrekenen : UserControl
    {


        private BesteldeItemService serviceBI;
        private Rekening rekening;

        public Afrekenen(Rekening r)
        {
            InitializeComponent();

            serviceBI = new BesteldeItemService();
            rekening = r;
            RefreshBillItems();




        }

       

        public void RefreshBillItems()
        {
            double total = rekening.TotaalPrijs;
            billListView.Items.Clear();
            double belasting = rekening.Belasting;
            

            foreach (Bestelling bestelling in rekening.Bestellingen) {
                List<BesteldeItem> besteldeItems = bestelling.BestellingItems;
                foreach (BesteldeItem b in besteldeItems)
                {

                    ListViewItem item = new ListViewItem(b.Hoeveelheid + "x");
                    item.SubItems.Add(b.menuItem.Naam);
                    item.SubItems.Add($"€ {(b.menuItem.Prijs * b.Hoeveelheid):0.00}");
                     


                    billListView.Items.Add(item);
                    if (b.Opmerking != null && b.Opmerking != "")
                    {
                        ListViewItem comment = new ListViewItem("");
                        comment.SubItems.Add(b.Opmerking + "");
                        comment.ForeColor = Color.Gray;
                        Font commentFont = new Font(comment.Font, FontStyle.Italic);

                        comment.Font = commentFont;
                        billListView.Items.Add(comment);

                    }

                   



                }
            }
            billTotalAmountText.Text = $"€ {(total):0.00}";
            totalVatPriceLabel.Text = $"€ {(belasting):0.00}";
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
           
            Form1.Instance.SwitchPanels(new BetalingScherm(rekening));
        }

       
    }
}
