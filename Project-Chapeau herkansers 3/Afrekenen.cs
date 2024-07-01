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
            VerversRekeningItems();
        }
        public void VerversRekeningItems()
        {
            rekeningLijst.Items.Clear();
            double totaal = rekening.TotaalPrijs;   
            foreach (Bestelling bestelling in rekening.Bestellingen) {               
                foreach (BesteldeItem besteldeItem in bestelling.BesteldeItems)
                {
                    VoegItemToeAanView(besteldeItem);
                }
            }
            labelRekeningTotaalHoeveelheid.Text = $"€ {(totaal):0.00}";
            labelBelastingNormaal.Text = $"€ {(rekening.BelastingNormaal):0.00}";
            labelBelastingAlcohol.Text = $"€ {(rekening.BelastingAlcoholisch):0.00}";
            labelBelastingTotaal.Text = $"€ {(rekening.BelastingNormaal+rekening.BelastingAlcoholisch):0.00}";
        }
        public void VoegItemToeAanView(BesteldeItem besteldeItem) {
            ListViewItem item = new ListViewItem(besteldeItem.Hoeveelheid + "x");
            item.SubItems.Add(besteldeItem.menuItem.Naam);
            item.SubItems.Add($"€ {(besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid):0.00}");
            rekeningLijst.Items.Add(item);
            if (besteldeItem.Opmerking != null && besteldeItem.Opmerking != "")
            {
                VoegOpmerkingToeAanView(besteldeItem.Opmerking);
            }
        }
        public void VoegOpmerkingToeAanView(string opmerking) {
            ListViewItem opmerkingItem = new ListViewItem("");
            opmerkingItem.SubItems.Add(opmerking + "");
            opmerkingItem.ForeColor = Color.Gray;
            Font commentLettertype = new Font(opmerkingItem.Font, FontStyle.Italic);
            opmerkingItem.Font = commentLettertype;
            rekeningLijst.Items.Add(opmerkingItem);
        }
        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchPanels(new BetalingScherm(rekening));
        }
    }
}
