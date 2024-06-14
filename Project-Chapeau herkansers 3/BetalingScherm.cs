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

namespace Project_Chapeau_herkansers_3
{
    public partial class BetalingScherm : UserControl
    {

        private List<SplitBillItem> splitBillItems;

        public List<SplitBillItem> SplitBillItems { get { return splitBillItems; } set {

                splitBillItems = value;
                RefreshView();
                    
                    } }

        public BetalingScherm()
        {
            InitializeComponent();
            splitBillItems = new List<SplitBillItem>();

            
        }
        public void RefreshView() {

            payementsPanel.Controls.Clear();
         
            foreach (SplitBillItem splitBillItem in SplitBillItems) {
               
                payementsPanel.Controls.Add(splitBillItem);


            }



        }

        private void btnConfirmSplit_Click(object sender, EventArgs e)
        {
            SplitBillItems.Clear();
            int splitAmount = int.Parse(inputSplitAmount.Text);
            for (int i = 0; i < splitAmount; i++) {
               
                SplitBillItems.Add(new SplitBillItem(BetaalMethode.Debit,0.00,0.00));


            }


        }
    }

    


}
