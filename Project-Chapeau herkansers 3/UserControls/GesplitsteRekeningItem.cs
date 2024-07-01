using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class GesplitsteRekeningItem : UserControl
    {
        public BetaalMethode methode = BetaalMethode.Debit;
        private double bedrag = 0.00;
        public double Bedrag { get { return bedrag; } set { bedrag = value; inputBetaalHoeveelheid.Text = $"{bedrag:0.00}"; } }        
        private double fooi = 0.00;
        public double Fooi { get { return fooi; } set { fooi = value; inputFooiHoeveelheid.Text = $"{fooi:0.00}"; } }
        public string getPaymentInput { get { return inputBetaalHoeveelheid.Text; } }
        public string getTipInput { get { return inputFooiHoeveelheid.Text; } }
        private BetalingScherm scherm;
        private int ID = 0;
        public GesplitsteRekeningItem(BetaalMethode methode, double bedrag, double fooi, BetalingScherm scherm, int ID)
        {
            InitializeComponent();
            this.methode = methode;
            this.scherm = scherm;
            this.ID = ID;
            Bedrag = bedrag;
            Fooi = fooi;
            comboBetaalMethode.SelectedIndex = 0;
        }
        public GesplitsteRekeningObject toObj() {
            return new GesplitsteRekeningObject(methode,bedrag,fooi);        
        }
        private void inputPayAmount_TextChanged(object sender, EventArgs e)
        {           
            if (double.TryParse(inputBetaalHoeveelheid.Text, out double betaling)) {
                bedrag = betaling;
                scherm.UpdateBetaalHoeveelheid(ID,betaling);
            }   
        }
        private void inputTipAmount_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(inputFooiHoeveelheid.Text, out double fooiBetaling))
            {
                fooi = fooiBetaling;
                scherm.UpdateFooiHoeveelheid(ID, fooiBetaling);
            }
        }
        private void comboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            methode = (BetaalMethode)comboBetaalMethode.SelectedIndex;
        }
    }
}
