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
    public partial class OpnemenBestellen : UserControl
    {
        public OpnemenBestellen(Tafel tafel)
        {
            InitializeComponent();
            MenuItemService menuItemService = new MenuItemService();
            Menu menu = menuItemService.GetAllItems();
            Bestelling bestelling = new Bestelling();
            buttonsVullen(menu, bestelling);
            VulListMetColumns();
        }

        private void buttonsVullen(Menu menu, Bestelling bestelling)
        {
            btnLunchKaart.Click += (sender, e) => VullenListView(listViewKaart, menu, MenuType.Lunch);
            btnDinerKaart.Click += (sender, e) => VullenListView(listViewKaart, menu, MenuType.Diner);
            btnDrankKaart.Click += (sender, e) => VullenListView(listViewKaart, menu, MenuType.Drank);
            btnToevoegenBestelling.Click += (sender, e) => ToevoegenAanBestelling(bestelling, menu);
            btnOpmerking.Click += (sender, e) => ToevoegenOpmerkingAanBestelling(bestelling);
            btnVerwijderAlles.Click += (sender, e) => VerwijderAllesUitListView(bestelling, menu);
            btnRijVerwijderen.Click += (sender, e) => RijVerwijderen(listViewBestelling, bestelling, menu);
            btnToevoegenEen.Click += (sender, e) => ToevoegenEenAanBestelling(listViewBestelling, bestelling, menu);
            btnVerwijderEen.Click += (sender, e) => VerwijderenEenAanBestelling(listViewBestelling, bestelling, menu);
            btnAfrekenen.Click += (sender, e) => AfrekenenBestelling(bestelling);
        }

        private void btnVerwijderAlles_Click(object sender, EventArgs e) { }
        private void btnLunchKaart_Click(object sender, EventArgs e) { }
        private void btnDinerKaart_Click(object sender, EventArgs e) { }
        private void btnDrankKaart_Click(object sender, EventArgs e) { }
        private void btnToevoegenBestelling_Click(object sender, EventArgs e) { }
        private void btnComment_Click(object sender, EventArgs e) { }
        private void btnRijVerwijderen_Click(object sender, EventArgs e) { }
        private void btnToevoegenEen_Click(object sender, EventArgs e) { }
        private void btnVerwijderEen_Click(object sender, EventArgs e) { }

        private void btnAfrekenen_Click(object sender, EventArgs e) { }

        private void AfrekenenBestelling(Bestelling bestelling)
        {

            //Afrekenen form1 = new Afrekenen(bestelling);
            //Application.Run(form1);
        }

        private void ToevoegenEenAanBestelling(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if(listView.SelectedItems.Count > 0)
            {
                BesteldItem besteldItem = (BesteldItem)listViewBestelling.SelectedItems[0].Tag;
                if(besteldItem.menuItem.Voorraad > 0)
                {
                    besteldItem.Hoeveelheid++;
                    besteldItem.menuItem.Voorraad--;
                    VulListViewBestelling(listViewBestelling, bestelling);
                    VullenListView(listViewKaart, menu, menu.MenuType);
                } else
                {
                    MessageBox.Show("Er is geen voorraad voor dit menu item.");
                }
            }
        }

        private void VerwijderenEenAanBestelling(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if (listView.SelectedItems.Count > 0)
            {
                BesteldItem besteldItem = (BesteldItem)listViewBestelling.SelectedItems[0].Tag;

                if (besteldItem.Hoeveelheid == 1)
                {
                    besteldItem.menuItem.Voorraad++;
                    bestelling.BestellingItems.Remove(besteldItem);
                } else if (besteldItem.Hoeveelheid > 0) {
                    besteldItem.Hoeveelheid--;
                    besteldItem.menuItem.Voorraad++;
                }
                else { 
                    bestelling.BestellingItems.Remove(besteldItem);
                }
                VulListViewBestelling(listViewBestelling, bestelling);
                VullenListView(listViewKaart, menu, menu.MenuType);
            }
        }

        private void RijVerwijderen(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if (listView.SelectedItems.Count > 0)
            {
                BesteldItem besteldItem = (BesteldItem)listViewBestelling.SelectedItems[0].Tag;
                besteldItem.menuItem.Voorraad += besteldItem.Hoeveelheid;
                bestelling.BestellingItems.Remove(besteldItem);
                listView.Items.Remove(listView.SelectedItems[0]);
                VullenListView(listViewKaart, menu, menu.MenuType);
            }
        }

        private void ToevoegenAanBestelling(Bestelling bestelling, Menu menu)
        {
            if (listViewKaart.SelectedItems.Count > 0)
            {
                MenuItem menuItem = (MenuItem)listViewKaart.SelectedItems[0].Tag;
                if(menuItem.Voorraad > 0)
                {
                    menuItem.Voorraad--;
                    BesteldItem bestaandItem = bestelling.BestellingItems.FirstOrDefault(bi => bi.menuItem.Naam == menuItem.Naam);

                    if (bestaandItem != null)
                    {
                        bestaandItem.Hoeveelheid++;
                    }
                    else
                    {
                        BesteldItem nieuwBesteldItem = new BesteldItem(menuItem);
                        bestelling.BestellingItems.Add(nieuwBesteldItem);
                    }

                    VulListViewBestelling(listViewBestelling, bestelling);
                    VullenListView(listViewKaart, menu, menu.MenuType);
                } else
                {
                    MessageBox.Show("Er is geen voorraad voor dit menu item.");
                }
            }
        }

        private void ToevoegenOpmerkingAanBestelling(Bestelling bestelling)
        {
            if (listViewBestelling.SelectedItems.Count > 0)
            {
                BesteldItem besteldItem = (BesteldItem)listViewBestelling.SelectedItems[0].Tag;
                besteldItem.Opmerking = txtOpmerking.Text;
                VulListViewBestelling(listViewBestelling, bestelling);
            }
        }

        private void VerwijderAllesUitListView(Bestelling bestelling, Menu menu)
        {
            foreach (BesteldItem besteldItem in bestelling.BestellingItems)
            {
                besteldItem.menuItem.Voorraad += besteldItem.Hoeveelheid;
            }

            bestelling.BestellingItems.Clear();
            listViewBestelling.Items.Clear();
            VullenListView(listViewKaart, menu, menu.MenuType);
        }

        private void VullenListView(System.Windows.Forms.ListView listView, Menu menu, MenuType menuType)
        {
            listView.Items.Clear();
            menu.MenuType = menuType;

            foreach (MenuItem menuItem in menu.MenuItems)
            {
                if((MenuType)menuItem.MenuId == menu.MenuType)
                {
                    ListViewItem item = new ListViewItem(menuItem.Naam);
                    item.SubItems.Add(menuItem.Prijs.ToString());
                    item.SubItems.Add(menuItem.Voorraad.ToString());
                    item.Tag = menuItem;
                    listView.Items.Add(item);
                }
            }
        }
        
        private void VulListViewBestelling(System.Windows.Forms.ListView listView, Bestelling bestelling)
        {
            listView.Items.Clear();

            foreach (BesteldItem besteldItem in bestelling.BestellingItems)
            {
                ListViewItem item = new ListViewItem(besteldItem.menuItem.Naam);
                item.SubItems.Add(besteldItem.menuItem.Prijs.ToString());
                item.SubItems.Add(besteldItem.Hoeveelheid.ToString());
                item.SubItems.Add(besteldItem.Opmerking);
                item.Tag = besteldItem;
                listView.Items.Add(item);
            }
        }

        private void VulListMetColumns()
        {
            listViewBestelling.Clear();
            listViewKaart.Clear();
            listViewBestelling.View = View.Details;
            listViewKaart.View = View.Details;

            listViewKaart.Columns.Add("Naam", 210);
            listViewKaart.Columns.Add("Prijs", 60);
            listViewKaart.Columns.Add("Voorraad", 100);

            listViewBestelling.Columns.Add("Naam", 170);
            listViewBestelling.Columns.Add("Prijs", 50);
            listViewBestelling.Columns.Add("Aantal", 60);
            listViewBestelling.Columns.Add("Opmerking", 100);
        }
    }
}
