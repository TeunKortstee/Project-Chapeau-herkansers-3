using Model;
using Service;

namespace Project_Chapeau_herkansers_3
{
    public partial class Afrekenen : UserControl
    {


        BesteldeItemService serviceBI;
        const double vatNormal = 0.06;
        const double vatAlcohol = 0.21;
       

        public Afrekenen(List<Bestelling> _bestellingen)
        {
            InitializeComponent();

            serviceBI = new BesteldeItemService();
            RefreshBillItems(_bestellingen);




        }

        public void RefreshBillItems(List<Bestelling> bestellingen)
        {
            double total = 0.00;
            billListView.Items.Clear();
            double vat = 0.00;
            

            foreach (Bestelling bestelling in bestellingen) {
                List<BesteldeItem> besteldeItems = serviceBI.GetItemsFromBestelling(bestelling.bestellingId);
                foreach (BesteldeItem b in besteldeItems)
                {

                    ListViewItem item = new ListViewItem(b.Hoeveelheid + "x");

                    //item.SubItems.Add(b.MenuItems[b.menuItem.MenuItemId].Naam);
                    //item.SubItems.Add("€ " + (menuItems.MenuItems[b.menuItem.MenuItemId].Prijs * b.Hoeveelheid));
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
                    total += itemTotal;
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
