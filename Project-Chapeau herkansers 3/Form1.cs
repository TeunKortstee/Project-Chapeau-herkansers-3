using Model;
using Project_Chapeau_herkansers_3.UserControls;
using System.Xml;

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
        public Form1()
        {
            InitializeComponent();
            //LoginControl loginControl = new LoginControl();
            //mainPanel.Controls.Add(loginControl);
            UserControlManager managerDashboard = new UserControlManager(this);
            mainPanel.Controls.Add(managerDashboard);
        }
        public void Switchpanels(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
        }
    }
}