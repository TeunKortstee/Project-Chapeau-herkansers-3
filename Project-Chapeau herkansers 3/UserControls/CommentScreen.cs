using Model;
using Service;
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
    public partial class CommentScreen : UserControl
    {
        private Rekening rekening;
        private RekeningService rekeningService;
        private List<SplitBillItemObj> paymentObjs;
        public CommentScreen(Rekening rekening, List<SplitBillItemObj> paymentObjs)
        {
            
            InitializeComponent();
            this.rekening = rekening;
            this.paymentObjs = paymentObjs;
            rekeningService = new RekeningService();
            panelAddComment.Visible = false;
        }

        private void btnContinuePayment_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchPanels(new BillSettledScreen(rekening,paymentObjs));
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            panelAddComment.Visible = true;
        }

        private void btnConfirmComment_Click(object sender, EventArgs e)
        {
            if (inputComment.Text != "")
            {
                rekeningService.VoegOpmerkingenToe(rekening, inputComment.Text);
                lblSaved.ForeColor = Color.Green;
                lblSaved.Text = "OPMERKING OPGESLAGEN";
            }
            else {
                lblSaved.ForeColor = Color.Red;
                lblSaved.Text = "VOEG OPMERKING TOE AUB";
            
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelAddComment.Visible = false;
            lblSaved.Text = "";
        }
    }
}
