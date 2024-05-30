using Model;
using Service;
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
    public partial class UserControlNewMenuItem : UserControl
    {
        private Form1 form1;
        private MenuItemService menuItemService;
        public UserControlNewMenuItem()
        {
            InitializeComponent();
            form1 = Form1.Instance;
        }
    }
}
