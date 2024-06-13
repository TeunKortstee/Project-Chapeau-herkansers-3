﻿using Model;
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
        private Form1 form;

        public UserControlManager()
        {
            InitializeComponent();
            this.form = Form1.Instance;
        }

        private void btnTableView_Click(object sender, EventArgs e)
        {

        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview(Functie.Serveerder));
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            form.SwitchPanels(new UserControlManageOverview(MenuType.Drank));
        }
         
        private void btnSa_Click(object sender, EventArgs e)
        {

        }
    }
}