using Model;
using Service;
using System.Xml.Linq;

namespace Project_Chapeau_herkansers_3
{
    public partial class Afrekenen : UserControl
    {
        private Rekening rekening;
        public Afrekenen(Rekening rekening)
        {
            this.rekening = rekening;
            InitializeComponent();                 
            RefreshBillItems();
        }
        public void RefreshBillItems()
        {
            billListView.Items.Clear();
            double total = rekening.TotaalPrijs;            
            double belasting = rekening.Belasting;         
            foreach (Bestelling bestelling in rekening.Bestellingen) {               
                foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
                {
                    AddItemToView(besteldeItem);
                }
            }
            billTotalAmountText.Text = $"€ {(total):0.00}";
            totalVatPriceLabel.Text = $"€ {(belasting):0.00}";
        }
        public void AddItemToView(BesteldeItem besteldeItem) {
            ListViewItem item = new ListViewItem(besteldeItem.Hoeveelheid + "x");
            item.SubItems.Add(besteldeItem.menuItem.Naam);
            item.SubItems.Add($"€ {(besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid):0.00}");
            billListView.Items.Add(item);
            if (besteldeItem.Opmerking != null && besteldeItem.Opmerking != "")
            {
                AddCommentToView(besteldeItem.Opmerking);
            }
        }
        public void AddCommentToView(string opmerking) {
            ListViewItem comment = new ListViewItem("");
            comment.SubItems.Add(opmerking + "");
            comment.ForeColor = Color.Gray;
            Font commentFont = new Font(comment.Font, FontStyle.Italic);
            comment.Font = commentFont;
            billListView.Items.Add(comment);
        }
        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchPanels(new BetalingScherm(rekening));
        }
    }
}
