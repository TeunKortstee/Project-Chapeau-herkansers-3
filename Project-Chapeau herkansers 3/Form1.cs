using Project_Chapeau_herkansers_3.UserControls;

namespace Project_Chapeau_herkansers_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //UserControl1 control1 = new UserControl1();
            
            OpnemenBestellen opnemenBestellen = new OpnemenBestellen(new Model.Tafel(), new Model.Personeel());
            mainPanel.Controls.Add(opnemenBestellen);
        }
    }
}