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
namespace Project_Chapeau_herkansers_3.UserControls
{





    public partial class SplitBillItem : UserControl
    {
        public BetaalMethode methode = BetaalMethode.Debit;

        private double bedrag = 0.00;
        public double Bedrag { get { return bedrag; } set { bedrag = value; inputPayAmount.Text = bedrag.ToString(); } }
        
        private double fooi = 0.00;
        public double Fooi { get { return fooi; } set { fooi = value; inputTipAmount.Text = fooi.ToString(); } }
        public SplitBillItem(BetaalMethode methode, double bedrag, double fooi)
        {
            this.methode = methode;
            this.bedrag = bedrag;
            this.fooi = fooi;

            InitializeComponent();

        }
    }
}
