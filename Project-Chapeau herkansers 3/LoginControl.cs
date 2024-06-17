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
            ChangePasswordHide();
        }
        private Personeel IsPersoneel(Personeel p)
        {
            try
            {
                LoginService service = new LoginService();
                p.email = EmailTxt.Text;
                Personeel personeel = service.GetPersoneel(p);
                if (!service.VerifyPassword(PasswordTxt.Text, personeel.WachtWoord))
                    throw new LoginException();

                return personeel;
            }
            catch (Exception ex)
            {
                throw new LoginException();
            }


        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Personeel personeel = new Personeel();
            try
            {
                if (CheckPassword(PasswordTxt.Text) && IsValidEmail())
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
                else
                    throw new LoginException();
            }
            catch (LoginException ex)
            {
                SomethingWentWrong(ex.Message, ErrorLbl);
            }
        }

        private void ChangePassword(Personeel personeel)
        {
            LoginService service = new LoginService();
            service.ChangePassword(personeel, ChangePasswordTxt.Text);
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
        private bool CheckPassword(string password)
        {
            string pattern = "^[0-9]{4}$";
            return Regex.IsMatch(password, pattern);
        }
        public bool IsValidEmail()
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(EmailTxt.Text, pattern);
        }
        private void SomethingWentWrong(string message, Label label)
        {
            PasswordTxt.Clear();
            ChangePasswordTxt.Clear();
            label.Text = message;
        }

        private void ChangePasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangePasswordCheck.Checked)
            {
                ChangePasswordShow();
            }
            else
            {
                ChangePasswordHide();
            }
        }
        private void ChangePasswordHide()
        {
            ChangePasswordTxt.Hide();
            Changepasswordbtn.Hide();
            LoginBtn.Show();
        }
        private void ChangePasswordShow()
        {
            ChangePasswordTxt.Show();
            Changepasswordbtn.Show();
            LoginBtn.Hide();
        }

        private void Changepasswordbtn_Click(object sender, EventArgs e)
        {
            Personeel personeel = new Personeel();
            try
            {
                if (CheckPassword(ChangePasswordTxt.Text) && CheckPassword(PasswordTxt.Text) && IsValidEmail())
                {
                    personeel = IsPersoneel(personeel);
                    ChangePassword(personeel);
                }
                else
                    throw new LoginException();
                Succeslbl.Text = "Wachtwoord succesvol verandert";
            }
            catch (LoginException ex)
            {
                SomethingWentWrong(ex.Message, ChangePasswordErrorlbl);
            }

        }
    }
}
