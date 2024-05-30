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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_Chapeau_herkansers_3
{
    public partial class OpnemenBestellen : UserControl
    {
        MenuItemService menuItemService;
        Model.Menu menu = new Model.Menu(); //Menu wordt hier aangemaakt, Model. want model en window menu
        
        private Tafel tafel;
        private Personeel personeel;

        public OpnemenBestellen()
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            //menu.MenuItems = menuItemService.GetAllItems();
            this.tafel = tafel;
            this.personeel = personeel;
            btnGebruiker.Text = personeel.Voornaam.ToString();
        }

        private void btnGebruiker_Click(object sender, EventArgs e)
        {
            //listViewKaart
        }

        private void btnVerwijderAlles_Click(object sender, EventArgs e)
        {

        }

        private void btnLunchKaart_Click(object sender, EventArgs e)
        {
            //VullenListView(listViewKaart, )
        }

        private void btnDinerKaart_Click(object sender, EventArgs e)
        {

        }

        private void btnDrankKaart_Click(object sender, EventArgs e)
        {

        }

        private void btnToevoegenBestelling_Click(object sender, EventArgs e)
        {

        }

        private void btnComment_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderEen_Click(object sender, EventArgs e)
        {

        }

        private void btnRijVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void btnAfrekenen_Click(object sender, EventArgs e)
        {
        }

        private void VullenListView(System.Windows.Forms.ListView listView, int menuId)
        {
            MenuItemService menuItemService = new MenuItemService();
            //menu.MenuItems = menuItemService.GetByItemType(menuType, menuId);


            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Naam", 210);
            listView.Columns.Add("Prijs", 60);
            listView.Columns.Add("Voorraad", 100);

            foreach (MenuItem menuItem in menu.MenuItems)
            {
                ListViewItem item = new ListViewItem(menuItem.Naam);
                item.SubItems.Add(menuItem.Prijs.ToString());
                
            }
        }
    }
}
