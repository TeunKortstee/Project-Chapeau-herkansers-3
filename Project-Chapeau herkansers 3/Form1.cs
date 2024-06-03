using Model;

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
        {
            InitializeComponent();
            _instance = this;
        }

        public void AddUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
        }
    }
}