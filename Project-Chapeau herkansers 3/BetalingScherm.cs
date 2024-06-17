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

        private List<SplitBillItem> splitBillItems;
        private BetalingService betalingService;
        private Rekening rekening;
        private double[] payments;
        private double[] tips;




        public BetalingScherm(Rekening rekening)
        {
            InitializeComponent();
            splitBillItems = new List<SplitBillItem>();
            lblAmountToBePaid.Text = $"€ {rekening.TotaalPrijs:0.00}";
            betalingService = new BetalingService();
            this.rekening = rekening;
            payments = new double[1];

            tips = new double[1];

        }
        public void RefreshView() {

            payementsPanel.Controls.Clear();
         
            foreach (SplitBillItem splitBillItem in splitBillItems) {
               
                payementsPanel.Controls.Add(splitBillItem);


            }



        }
        public void UpdatePaymentAmount(int ID, double payment) {

            if (payments.Length > ID) {

                payments[ID] = payment;
                
            }

            UpdateAmountPaidText();
        
        }

        public void UpdateTipAmount(int ID, double tip)
        {

            if (tips.Length > ID)
            {

                tips[ID] = tip;

            }

            UpdateAmountPaidText();

        }



        public void UpdateAmountPaidText() {
            lblAmountPaid.Text = $"€ {betalingService.AddDoubleArray(payments):0.00}";
            lblTip.Text = $"€ {betalingService.AddDoubleArray(tips):0.00}";
            lblChange.Text = $"€ {Math.Clamp( betalingService.CalculateChange(rekening.TotaalPrijs, betalingService.AddDoubleArray(payments)),0,double.MaxValue):0.00}";
        }
        


        private void btnConfirmSplit_Click(object sender, EventArgs e)
        {

            if (int.TryParse(inputSplitAmount.Text, out int splitAmount) && splitAmount > 0)
            {
                splitBillItems.Clear();

                payments = betalingService.GetPaymentPerPerson(rekening.TotaalPrijs, splitAmount);
                tips = betalingService.GetTipPerPerson(splitAmount);

                for (int i = 0; i < splitAmount; i++)
                {


                    splitBillItems.Add(new SplitBillItem(BetaalMethode.Debit, payments[i], tips[i], this, i));


                }
                UpdateAmountPaidText();
                RefreshView();
            }
            else {

                lblSplitAmountErrorText.Text = "Vul een valide hoeveelheid in AUB!";
            
            }

        }

        private void btnPay_Click(object sender, EventArgs e)
        {


            List<SplitBillItemObj> paymentObjs = new List<SplitBillItemObj>();

            foreach (SplitBillItem item in splitBillItems) {

                if (!double.TryParse(item.getPaymentInput, out double result) || !double.TryParse(item.getTipInput, out double result2)) {

                    lblPaymentErrorText.Text = "Vul valide hoeveelheden in AUB!";
                    return;
                
                }
                paymentObjs.Add(item.toObj());
            }

            int code = betalingService.ConfirmPayments(rekening,paymentObjs);
            

            if (code == 0) {

                lblPaymentErrorText.Text = "Betaling(en) niet genoeg!";

            } else if (code == 1)
            {

                lblPaymentErrorText.Text = "Vul valide hoeveelheden in AUB!";

            }
            else if (code == 2)
            {

                Form1.Instance.SwitchPanels(new CommentScreen(rekening, paymentObjs));

            }



        }

        private void inputSplitAmount_TextChanged(object sender, EventArgs e)
        {
            lblSplitAmountErrorText.Text = "";
        }
    }

    


}
