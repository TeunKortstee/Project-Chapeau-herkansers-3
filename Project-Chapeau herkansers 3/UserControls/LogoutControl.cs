using Model;

namespace Project_Chapeau_herkansers_3
{
    public partial class LogoutControl : UserControl
    {
        public LogoutControl()
        {
            InitializeComponent();
            InitializeLabels();
        }
        private void InitializeLabels()
        {
            Form1 form = Form1.Instance;
            AchternaamLbl.Text = form.personeel.AchterNaam;
            EmailLbl.Text = form.personeel.email;
            FunctieLbl.Text = form.personeel.Functie.ToString();
        }

        private void UitlogBtn_Click(object sender, EventArgs e)
        {
            Form1 form = Form1.Instance;
            form.personeel = new Personeel();
            form.ChangeButtonText("Gebruiker");
            form.SwitchPanels(new LoginControl());
        }
    }
}
