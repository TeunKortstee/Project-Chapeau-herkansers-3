using Model;

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
            StatusBox.SelectedIndex = (int)tafel.status;
        }

        private void MaakBestellingBtn_Click(object sender, EventArgs e)
        {
            //Open naar bestelling Ui
            OpnemenBestellen opnemenBestellen = new OpnemenBestellen();
            opnemenBestellen.Tag = this;
            AddUserControl(opnemenBestellen);
        }

        private void TerugBtn_Click(object sender, EventArgs e)
        {

            //sla tafel op in db

            //ga terug naar tafeloverzicht
            TafelOverzichtUserControl tafelOverzichtUserControl = (TafelOverzichtUserControl)this.Tag;
            AddUserControl(new TafelOverzichtUserControl(tafelOverzichtUserControl.form));
        }
        private void AddUserControl(UserControl userControl)
        {
            TafelOverzichtUserControl tafelOverzicht = (TafelOverzichtUserControl)this.Tag;
            tafelOverzicht.form.AddUserControl(userControl);
        }
        private void SaveTafel()
        {
            //Sla tafel op in database
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tafel.status = (TafelStatus)StatusBox.SelectedIndex;
            SetLabels();
        }
    }
}
