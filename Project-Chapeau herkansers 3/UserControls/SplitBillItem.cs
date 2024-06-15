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
using Service;

namespace Project_Chapeau_herkansers_3.UserControls
{





    public partial class SplitBillItem : UserControl
    {
        public BetaalMethode methode = BetaalMethode.Debit;

        private double bedrag = 0.00;
        public double Bedrag { get { return bedrag; } set { bedrag = value; inputPayAmount.Text = $"{bedrag:0.00}"; } }
        
        private double fooi = 0.00;
        public double Fooi { get { return fooi; } set { fooi = value; inputTipAmount.Text = $"{fooi:0.00}"; } }

        private BetalingScherm scherm;

        private int ID = 0;
        public SplitBillItem(BetaalMethode methode, double bedrag, double fooi, BetalingScherm scherm, int ID)
        {
            

            InitializeComponent();
            this.methode = methode;
            this.scherm = scherm;
            this.ID = ID;
            Bedrag = bedrag;
            Fooi = fooi;
            

        }

        private void inputPayAmount_TextChanged(object sender, EventArgs e)
        {
           
            if (double.TryParse(inputPayAmount.Text, out double payment)) {

                scherm.UpdatePaymentAmount(ID,payment);

            }

            

        }

        private void inputTipAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
