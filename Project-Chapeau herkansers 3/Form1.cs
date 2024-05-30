using Model;
using Project_Chapeau_herkansers_3.UserControls;

namespace Project_Chapeau_herkansers_3
{
    public partial class Form1 : Form
    {
        public Personeel personeel { get; set; }
        public Form1()
        {
            InitializeComponent();
            //UserControl1 control1 = new UserControl1();
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