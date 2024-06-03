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
        private Form1 form1;

        public UserControlManager(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {

        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            form1.Switchpanels(new UserControlOverview(form1, Functie.Serveerder));
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            form1.Switchpanels(new UserControlOverview(form1, MenuType.Drank));
        }

        private void btnSa_Click(object sender, EventArgs e)
        {

        }
    }
}
