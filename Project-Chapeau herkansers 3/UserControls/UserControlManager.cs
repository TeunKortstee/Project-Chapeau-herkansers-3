using Model;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlManager : UserControl
    {
        private const Functie startFunctie = Functie.Serveerder;
        private const MenuType startMenu = MenuType.Drank;

        private Form1 form;

        public UserControlManager()
        {
            InitializeComponent();
            this.form = Form1.Instance;
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview(startFunctie));
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview(startMenu));
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlSalesOverview());
        }
    }
}
