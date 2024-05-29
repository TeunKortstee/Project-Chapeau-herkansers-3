using Model;
using Service;
using System.Text.RegularExpressions;

namespace Project_Chapeau_herkansers_3
{
    public partial class LoginControl : UserControl
    {
        private Form1 _form1;
        private LoginService loginService;
        public LoginControl()
        {
            InitializeComponent();
            _form1 = Form1.Instance;
        }
        private bool IsPersoneel(Personeel p)
        {
            //get user from db
            Personeel personeel = loginService.GetPersoneel(p);
            if (personeel == null)
            {
                return false;
            }
            if (!loginService.VerifyPassword(PasswordTxt.Text, personeel.Salt, personeel.WachtWoord))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //write method that checks regex
            Personeel personeel = new Personeel();
            try
            {
                if (CheckPassword() && IsValidEmail())
                {
                    personeel.email = EmailTxt.Text;
                    if (CreateUserCheck.Checked)
                    {
                        //Send user to database
                    }
                    else
                    {
                        //if (IsPersoneel(personeel))
                        //{
                        //    //return user to mainform

                        //    //Open volgende UserControl

                        //}
                        //else
                        //{
                        //    throw new LoginException();
                        //}
                    }
                }
                else
                {
                    throw new LoginException();
                }
            }
            catch (LoginException ex)
            {
                SomethingWentWrong(ex.Message);

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
            //display errors

            PasswordTxt.Clear();
            ErrorLbl.Text = message;
        }
    }
}
