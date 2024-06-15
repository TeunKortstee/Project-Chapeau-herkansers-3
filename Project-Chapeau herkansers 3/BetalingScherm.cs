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


       

        public BetalingScherm(Rekening rekening)
        {
            InitializeComponent();
            splitBillItems = new List<SplitBillItem>();
            lblAmountToBePaid.Text = $"€ {rekening.TotaalPrijs:0.00}";
            betalingService = new BetalingService();
            this.rekening = rekening;
            payments = new double[1];


            
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

        public void UpdateAmountPaidText() {
            lblAmountPaid.Text = $"€ {betalingService.AddDoubleArray(payments):0.00}";
        }

        private void btnConfirmSplit_Click(object sender, EventArgs e)
        {
            splitBillItems.Clear();
            int splitAmount = int.Parse(inputSplitAmount.Text);
            payments = betalingService.GetPaymentPerPerson(rekening.TotaalPrijs,splitAmount);
            
         
            for (int i = 0; i < splitAmount; i++) {

               
                splitBillItems.Add(new SplitBillItem(BetaalMethode.Debit, payments[i],0.00,this,i));
                

            }
            UpdateAmountPaidText();
            RefreshView();

        }
    }

    


}
