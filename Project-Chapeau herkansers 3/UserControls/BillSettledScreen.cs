using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class BillSettledScreen : UserControl
    {
       
        public BillSettledScreen(Rekening rekening, List<SplitBillItemObj> paymentObjs)
        {
            InitializeComponent();
            

            double totalAmountPaid = 0.00;
            double totalTipPaid = 0.00;

            foreach (SplitBillItemObj payment in paymentObjs)
            {

                
                    totalAmountPaid += payment.payment;
                    totalTipPaid += payment.tip;
                
            }


            lblOrderPrice.Text = $"€ {rekening.TotaalPrijs:0.00}";
            lblAmountPaid.Text = $"€ {totalAmountPaid:0.00}";
            lblTipAmount.Text = $"€ {totalTipPaid:0.00}";
            lblVat.Text = $"€ {rekening.Belasting:0.00}";




        }
    }
}
