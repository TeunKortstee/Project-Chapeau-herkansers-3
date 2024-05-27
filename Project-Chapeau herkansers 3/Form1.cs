namespace Project_Chapeau_herkansers_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Controls.Add(new TafelOverzichtUserControl(this));
        }
        public void AddUserControl(UserControl control)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(control);
        }
    }
}