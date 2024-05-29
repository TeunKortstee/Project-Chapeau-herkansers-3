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
        Model.Menu menu; //Menu wordt hier aangemaakt, Model. want model en window menu
        
        private Tafel tafel;
        private Personeel personeel;

        public OpnemenBestellen(Tafel tafel, Personeel personeel)
        {
            InitializeComponent();
            menuItemService = new MenuItemService();
            menu = menuItemService.GetAllItems();
            this.tafel = tafel;
            this.personeel = personeel;
            if(personeel.VoorNaam != null)
            {
                btnGebruiker.Text = personeel.VoorNaam.ToString();
            }
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

            VullenListView(listViewKaart, (int)MenuType.Lunch);
        }

        private void btnDinerKaart_Click(object sender, EventArgs e)
        {
            VullenListView(listViewKaart, (int)MenuType.Diner);
        }

        private void btnDrankKaart_Click(object sender, EventArgs e)
        {
            VullenListView(listViewKaart, (int)MenuType.Drank);
        }

        private void btnToevoegenBestelling_Click(object sender, EventArgs e)
        {
            MenuItem menuItem = (MenuItem)listViewKaart.SelectedItems[0].Tag;
            
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
            listView.Clear();
            listView.View = View.Details;

            listView.Columns.Add("Naam", 210);
            listView.Columns.Add("Prijs", 60);
            listView.Columns.Add("Voorraad", 100);

            foreach (MenuItem menuItem in menu.MenuItems)
            {
                if(menuItem.MenuId == menuId)
                {
                    ListViewItem item = new ListViewItem(menuItem.Naam);
                    item.SubItems.Add(menuItem.Prijs.ToString());
                    item.SubItems.Add(menuItem.Voorraad.ToString());
                    item.Tag = menuItem;
                    listView.Items.Add(item);
                }
            }
        }
    }
}
