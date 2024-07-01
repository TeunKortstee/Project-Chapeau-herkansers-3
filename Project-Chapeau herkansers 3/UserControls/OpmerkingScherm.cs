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
    public partial class OpmerkingScherm : UserControl
    {
        private Rekening rekening;
        private RekeningService rekeningService;
      
        public OpmerkingScherm(Rekening rekening)
        {
            InitializeComponent();
            this.rekening = rekening;           
            rekeningService = new RekeningService();
            panelVoegOpmerkingToe.Visible = false;
        }
        private void btnContinuePayment_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchPanels(new RekeningBetaaldScherm(rekening));
        }
        private void btnAddComment_Click(object sender, EventArgs e)
        {
            panelVoegOpmerkingToe.Visible = true;
        }
        private void btnConfirmComment_Click(object sender, EventArgs e)
        {
            if (inputOpmerkingen.Text != "")
            {
                rekeningService.VoegOpmerkingenToe(rekening, inputOpmerkingen.Text);
                labelFeedback.ForeColor = Color.Green;
                labelFeedback.Text = "OPMERKING OPGESLAGEN";
            }
            else {
                labelFeedback.ForeColor = Color.Red;
                labelFeedback.Text = "VOEG OPMERKING TOE AUB";            
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            panelVoegOpmerkingToe.Visible = false;
            labelFeedback.Text = "";
        }
    }
}
