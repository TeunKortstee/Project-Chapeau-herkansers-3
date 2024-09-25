using Model;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlManager : UserControl
    {
        private Form1 form;

        public UserControlManager()
        {
            InitializeComponent();
            this.form = Form1.Instance;
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlPersoneelOverzicht());
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlItemOverzicht(MenuItemControl.Menu));
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlItemOverzicht(MenuItemControl.Inkomen));
        }
        private void btnStock_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlItemOverzicht(MenuItemControl.Voorraad));
        }
    }
}
