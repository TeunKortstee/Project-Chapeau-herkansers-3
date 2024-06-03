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
    public partial class UserControlNewPersoneel : UserControl
    {
        private Form1 form;
        private MenuItemService? menuItemService;
        private PersoneelService? personeelService;
        public UserControlNewPersoneel(Form1 form1)
        {
            InitializeComponent();
            this.form = form1;
        }
        public UserControlNewPersoneel(Form1 form1, MenuType menu)
        {
            InitializeComponent();
            this.form = form1;
            this.personeelService = null;
            this.menuItemService = new MenuItemService();
            DisplayUIElements();
        }
        private void DisplayUIElements()
        {
            if (this.personeelService == null)
            {
                lblObject.Text = "Nieuw MenuItem";
                //btn2.Location = new Point(158, 194);
                lbl1.Text = "Naam";
                lbl2.Text = "Prijs";
                lbl3.Text = "Voorraad";
            }
            else
            {
                lblObject.Text = "Nieuw Werknemer";
                lbl1.Text = "Voornaam";
                lbl2.Text = "Achternaam";
                lbl3.Text = "Email";
            }
        }

    }
}
