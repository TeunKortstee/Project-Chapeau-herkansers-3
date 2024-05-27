using System.Text.RegularExpressions;

namespace Project_Chapeau_herkansers_3
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }
        private bool IsPersoneel()
        {
            return true;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //write method that checks regex
            if (CheckPassword())
            {
                if (CreateUserCheck.Checked)
                {
                    //Send user to database
                }
                else
                {
                    if (IsPersoneel())
                    {
                        //return user to mainform
                    }
                    else
                    {
                        SomethingWentWrong();
                    }
                }
            }
            else
            {
                SomethingWentWrong();
            }
        }
        private bool CheckPassword()
        {
            string pattern = "^[0-9]{4}$";
            return Regex.IsMatch(PasswordTxt.Text, pattern);
        }
        private void SomethingWentWrong()
        {
            //display errors

            PasswordTxt.Clear();
        }
    }
}
