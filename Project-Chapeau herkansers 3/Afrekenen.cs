using Model;
using Service;
using System.Xml.Linq;

namespace Project_Chapeau_herkansers_3
{
    public partial class Afrekenen : UserControl
    {


        BesteldeItemService serviceBI;
        const double vatNormal = 0.06;
        const double vatAlcohol = 0.21;
       

        public Afrekenen(Rekening rekening)
        {
            InitializeComponent();

            serviceBI = new BesteldeItemService();
            RefreshBillItems(rekening);




        }

       

        public void RefreshBillItems(Rekening rekening)
        {
            double total = rekening.TotaalPrijs;
            billListView.Items.Clear();
            double vat = 0.00;
            

            foreach (Bestelling bestelling in rekening.Bestellingen) {
                List<BesteldeItem> besteldeItems = bestelling.BestellingItems;
                foreach (BesteldeItem b in besteldeItems)
                {

                    ListViewItem item = new ListViewItem(b.Hoeveelheid + "x");
                    item.SubItems.Add(b.menuItem.Naam);
                    item.SubItems.Add("€ " + (b.menuItem.Prijs * b.Hoeveelheid));
                     


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

                    double itemTotal = (b.menuItem.Prijs * b.Hoeveelheid);
                   
                    if (b.menuItem.IsAlcoholisch)
                    {
                        vat += itemTotal * vatAlcohol;

                    }
                    else
                    {
                        vat += itemTotal * vatNormal;
                    }



                }
            }
            billTotalAmountText.Text = "€ " + total;
            totalVatPriceLabel.Text = "€ " + vat;
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {

        }
    }
}
