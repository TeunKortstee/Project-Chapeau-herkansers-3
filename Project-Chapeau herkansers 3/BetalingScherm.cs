using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Project_Chapeau_herkansers_3.UserControls;
using Service;

namespace Project_Chapeau_herkansers_3
{
    public partial class BetalingScherm : UserControl
    {
        private List<GesplitsteRekeningItem> gesplitsteRekeningItems;
        private BetalingService betalingService;
        private Rekening rekening;
        private double[] betalingen;
        private double[] fooiBetalingen;
        public BetalingScherm(Rekening rekening)
        {
            this.rekening = rekening;
            InitializeComponent();
            gesplitsteRekeningItems = new List<GesplitsteRekeningItem>();
            labelHoeveelheidOmTeBetalen.Text = $"€ {rekening.TotaalPrijs:0.00}";
            betalingService = new BetalingService();            
            betalingen = new double[1];
            fooiBetalingen = new double[1];
        }
        public void VerversLijst() {
            betalingenPanel.Controls.Clear();         
            foreach (GesplitsteRekeningItem gesplitseRekeningItem in gesplitsteRekeningItems) {               
                betalingenPanel.Controls.Add(gesplitseRekeningItem);
            }
        }
        public void UpdateBetaalHoeveelheid(int ID, double betaling) {
            if (betalingen.Length > ID) {
                betalingen[ID] = betaling;                
            }
            UpdateHoeveelheden();        
        }
        public void UpdateFooiHoeveelheid(int ID, double fooi)
        {
            if (fooiBetalingen.Length > ID)
            {
                fooiBetalingen[ID] = fooi;
            }
            UpdateHoeveelheden();
        }
        public void UpdateHoeveelheden() {
            labelHoeveelheidBetaald.Text = $"€ {betalingService.VoegDoublesBijElkaar(betalingen):0.00}";
            labelFooi.Text = $"€ {betalingService.VoegDoublesBijElkaar(fooiBetalingen):0.00}";
            labelWisselgeld.Text = $"€ {Math.Clamp(betalingService.BerekenWisselgeld(rekening.TotaalPrijs, betalingService.VoegDoublesBijElkaar(betalingen)),0,double.MaxValue):0.00}";
        }
        private void btnConfirmSplit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputSplitAmount.Text, out int splitAmount) && splitAmount > 0)
            {
                gesplitsteRekeningItems.Clear();
                betalingen = betalingService.KrijgBetalingPerPersoon(rekening.TotaalPrijs, splitAmount);
                fooiBetalingen = betalingService.KrijgGesplitsteFooi(splitAmount);
                for (int i = 0; i < splitAmount; i++)
                {
                    gesplitsteRekeningItems.Add(new GesplitsteRekeningItem(BetaalMethode.Debit, betalingen[i], fooiBetalingen[i], this, i));
                }
                UpdateHoeveelheden();
                VerversLijst();
            }
            else {
                lblSplitAmountErrorText.Text = "Vul een valide hoeveelheid in AUB!";            
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            List<GesplitsteRekeningObject> paymentObjs = new List<GesplitsteRekeningObject>();
            foreach (GesplitsteRekeningItem item in gesplitsteRekeningItems) {
                if (!double.TryParse(item.getPaymentInput, out double result) || !double.TryParse(item.getTipInput, out double result2)) {
                    lblPaymentErrorText.Text = "Vul valide hoeveelheden in AUB!";
                    return;                
                }
                paymentObjs.Add(item.toObj());
            }
            int exitCode = betalingService.BevestigBetalingen(rekening,paymentObjs);    
            if (exitCode == 0) {
                lblPaymentErrorText.Text = "Betaling(en) niet genoeg!";
            } else if (exitCode == 1)
            {
                lblPaymentErrorText.Text = "Vul valide hoeveelheden in AUB!";
            }
            else if (exitCode == 2)
            {
                Form1.Instance.SwitchPanels(new OpmerkingScherm(rekening, paymentObjs));
            }
        }
        private void inputSplitAmount_TextChanged(object sender, EventArgs e)
        {
            lblSplitAmountErrorText.Text = "";
        }
    }
}
