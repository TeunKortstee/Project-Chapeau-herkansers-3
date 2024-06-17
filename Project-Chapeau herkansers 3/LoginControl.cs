using Model;
using Project_Chapeau_herkansers_3.UserControls;
using Service;
using System.Text.RegularExpressions;

namespace Project_Chapeau_herkansers_3
{
    public partial class LoginControl : UserControl
    {
        private Form1 _form1;
        public LoginControl()
        {
            InitializeComponent();
            _form1 = Form1.Instance;
        }
        private Personeel IsPersoneel(Personeel p)
        {
            LoginService service = new LoginService();
            Personeel personeel = service.GetPersoneel(p);
            if (personeel == null)
                return null;
            if (!service.VerifyPassword(PasswordTxt.Text, personeel.WachtWoord))
                return null;
            return personeel;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Personeel personeel = new Personeel();
            try
            {
                if (CheckPassword() && IsValidEmail())
                {
                    if (CreateUserCheck.Checked)
                    {
                        changePassword(personeel);
                    }
                    else
                    {
                        personeel = IsPersoneel(personeel);
                        if (personeel != null)
                        {
                            _form1.personeel = personeel;
                            openNextView(personeel);
                        }
                        else
                            throw new LoginException();
                    }
                }
                else
                    throw new LoginException();
            }
            catch (LoginException ex)
            {
                SomethingWentWrong(ex.Message);
            }
        }

        private void changePassword(Personeel personeel)
        {
            personeel.email = EmailTxt.Text;
            LoginService service = new LoginService();
            personeel = service.GetPersoneel(personeel);
            service.ChangePassword(personeel, PasswordTxt.Text);
        }
        private void openNextView(Personeel personeel)
        {
            switch (personeel.Functie)
            {
                case Functie.Serveerder:
                    _form1.SwitchPanels(new TafelOverzichtUserControl());
                    break;
                case Functie.Manager:
                    _form1.SwitchPanels(new UserControlManager());
                    break;

            }
        }
        private bool CheckPassword()
        {
            string pattern = "^[0-9]{4}$";
            return Regex.IsMatch(PasswordTxt.Text, pattern);
        }
        public bool IsValidEmail()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(EmailTxt.Text, pattern);
        }
        private void SomethingWentWrong(string message)
        {
            PasswordTxt.Clear();
            ErrorLbl.Text = message;
        }
    }
}
