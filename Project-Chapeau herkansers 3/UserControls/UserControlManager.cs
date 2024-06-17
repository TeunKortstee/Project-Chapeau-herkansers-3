using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class UserControlManager : UserControl
    {
        const Functie startFunctie = Functie.Serveerder;
        const MenuType startMenu = MenuType.Drank;

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


        private void btnSa_Click(object sender, EventArgs e)
        {
        
        }

      
        private void btnSales_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlSalesOverview());
        }
    }
}
