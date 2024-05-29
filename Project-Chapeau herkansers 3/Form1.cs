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
            personeel = new Personeel();
            panel1.Controls.Add(new LoginControl());
        }
        public void AddUserControl(UserControl control)
        {
            panel1.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panel1.Controls.Add(control);
        }
        public void ShowForm()
        {
            this.Show();
        }
    }
}