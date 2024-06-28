using Model;
using Service;

namespace Project_Chapeau_herkansers_3
{
    public partial class TafelStatusUI : UserControl
    {
        private Tafel tafel;
        public TafelStatusUI(Tafel tafel)
        {
            InitializeComponent();
            this.tafel = tafel;
            SetLabels();
            FillComboBox();
        }
        private void SetLabels()
        {
            TafelTitelTag.Text = "Tafel ";
            StatusLbl.Text = "Deze tafel is nu ";
            TafelTitelTag.Text += tafel.Id.ToString();
            StatusLbl.Text += tafel.status.ToString();
        }

        private void FillComboBox()
        {
            foreach (var status in Enum.GetValues<TafelStatus>())
            {
                StatusBox.Items.Add(status);
            }
            StatusBox.SelectedIndex = (int)tafel.status - 1;
        }

        private void MaakBestellingBtn_Click(object sender, EventArgs e)
        {
            Exit(new OpnemenBestellen(this.tafel));
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {
            SaveTafel();
            Form1 form1 = Form1.Instance;
            form1.SwitchPanels(new TafelOverzichtUserControl());
        }
        private void Exit(UserControl control)
        {
            SaveTafel();
            Form1 form1 = Form1.Instance;
            form1.SwitchPanels(control);
        }
        private void SaveTafel()
        {
            //Sla tafel op in database
            TafelService service = new TafelService();
            service.ChangeTafel(this.tafel);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tafel.status = (TafelStatus)StatusBox.SelectedIndex + 1;
            SetLabels();
        }

        private void BestellingDisplayBtn_Click(object sender, EventArgs e)
        {
            Exit(new TafelBestellingUserControl(tafel));
        }

        private void AfrekenenBtn_Click(object sender, EventArgs e)
        {
            RekeningService rekeningService = new RekeningService();
            BestellingService bestellingService = new BestellingService();
            if (bestellingService.GetBestellingen(tafel.Id).Count > 0)
            {
                Rekening gemaakteRekening = rekeningService.CreateRekening(tafel);
                Afrekenen afrekenScherm = new Afrekenen(gemaakteRekening);
                Exit(afrekenScherm);
            }
            else
            {
                MessageBox.Show("There are no items to check out!");
            }
        }
        public void SetStringName(string message)
        {
            labelBestellingAangemaakt.Text = message;
        }
    }

}
