using Model;
<<<<<<<<< Temporary merge branch 1
=========
using Project_Chapeau_herkansers_3.UserControls;
>>>>>>>>> Temporary merge branch 2


namespace Project_Chapeau_herkansers_3
{
    public partial class Form1 : Form
    {
        public Personeel personeel { get; set; }
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }
        private Form1()
            InitializeComponent();
            SwitchPanels(new LoginControl());
<<<<<<<<< Temporary merge branch 1
            personeel = new Personeel();
            //SwitchPanels(new LoginControl());
            //SwitchPanels(new UserControlManager());
        }

        public void SwitchPanels(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            Size userControlSize = userControl.Size;

            mainPanel.Size = userControlSize;

            userControlSize.Width += 30;
            userControlSize.Height += 60;

            _instance.Size = userControlSize;

            mainPanel.Controls.Add(userControl);


        }
    }
}
