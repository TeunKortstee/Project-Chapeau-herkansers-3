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





    public partial class SplitBillItem : UserControl
    {
        public BetaalMethode methode = BetaalMethode.Debit;

        private double bedrag = 0.00;
        public double Bedrag { get { return bedrag; } set { bedrag = value; inputPayAmount.Text = $"{bedrag:0.00}"; } }
        
        private double fooi = 0.00;
        public double Fooi { get { return fooi; } set { fooi = value; inputTipAmount.Text = $"{fooi:0.00}"; } }

        public string getPaymentInput { get { return inputPayAmount.Text; } }

        public string getTipInput { get { return inputTipAmount.Text; } }


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
            comboPaymentMethod.SelectedIndex = 0;

        }

        public SplitBillItemObj toObj() {

            return new SplitBillItemObj(methode,bedrag,fooi);
        
        }

        private void inputPayAmount_TextChanged(object sender, EventArgs e)
        {
           
            if (double.TryParse(inputPayAmount.Text, out double payment)) {
                bedrag = payment;
                scherm.UpdatePaymentAmount(ID,payment);

            }

            

        }


        private void inputTipAmount_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(inputTipAmount.Text, out double tip))
            {
                fooi = tip;
                scherm.UpdateTipAmount(ID, tip);

            }
        }

        private void comboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            methode = (BetaalMethode)comboPaymentMethod.SelectedIndex;
        }
    }
}
