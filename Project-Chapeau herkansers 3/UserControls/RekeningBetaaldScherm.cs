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
    public partial class RekeningBetaaldScherm : UserControl
    {
        RekeningService rekeningService;
        public RekeningBetaaldScherm(Rekening rekening)
        {
            InitializeComponent();
            rekeningService = new RekeningService();
            rekeningService.BetaalRekening(rekening);
            double totaleHoeveelheidBetaald = 0.00;
            double totaleFooiBetaald = 0.00;
            foreach (Betaling betaling in rekening.Betalingen)
            {
                totaleHoeveelheidBetaald += betaling.Bedrag;
                totaleFooiBetaald += betaling.Fooi;                
            }
            labelTotaalPrijs.Text = $"€ {rekening.TotaalPrijs:0.00}";
            labelHoeveelheidBetaald.Text = $"€ {totaleHoeveelheidBetaald:0.00}";
            labelFooiBetaald.Text = $"€ {totaleFooiBetaald:0.00}";
            labelBelastingNormaal.Text = $"€ {rekening.BelastingNormaal:0.00}";
            labelBelastingAlcohol.Text = $"€ {rekening.BelastingAlcoholisch:0.00}";
            labelBelastingTotaal.Text = $"€ {(rekening.BelastingNormaal+rekening.BelastingAlcoholisch):0.00}";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1.Instance.SwitchPanels(new TafelOverzichtUserControl());
        }
    }
}
