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

namespace Project_Chapeau_herkansers_3
{
    public partial class Afrekenen : Form
    {
        Menu menuItems;
        MenuItemService serviceMI;
        BesteldeItemService serviceBI;
        public int bestellingID = 2;
        
        public Afrekenen()
        {
            InitializeComponent();
            serviceMI = new MenuItemService();
            serviceBI = new BesteldeItemService();
            menuItems = serviceMI.GetAllItems();
            RefreshBillItems();


        }

        public void RefreshBillItems() {
            List<BesteldeItem> besteldeItems = serviceBI.GetItemsFromBestelling(bestellingID);
            billListView.Items.Clear();
            decimal total = 0.00M;
            foreach (BesteldeItem b in besteldeItems)
            {

                ListViewItem item = new ListViewItem(b.Hoeveelheid + "x");

                item.SubItems.Add(menuItems.MenuItems[b.MenuItemID].Naam);
                item.SubItems.Add("€ " + (menuItems.MenuItems[b.MenuItemID].Prijs * b.Hoeveelheid));
                billListView.Items.Add(item);
                total += (menuItems.MenuItems[b.MenuItemID].Prijs * b.Hoeveelheid);


            }
            billTotalAmountText.Text = "€ " + total;

        }

    }
}
