using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            Form1 form1 = Form1.Instance;
            buttonsVullen(menu, bestelling, form1, tafel);
            VulTekstTafel(tafel);
            VulListMetColumns();
        }

        private void buttonsVullen(Menu menu, Bestelling bestelling, Form1 form1, Tafel tafel)
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
            btnAfrekenen.Click += (sender, e) => AfrekenenBestelling(bestelling, form1, tafel);
        }

        private void VulTekstTafel(Tafel tafel)
        {
            if(tafel != null)
            {
                labelSelectedTafel.Text = $"Tafel #{tafel.Id}";
            }
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

        private void AfrekenenBestelling(Bestelling bestelling, Form1 form1, Tafel tafel)
        {
            if(listViewBestelling.Items.Count > 0)
            {
                BesteldeItemService besteldeItemService = new BesteldeItemService();
                besteldeItemService.BestellingAanmaken(bestelling, form1.personeel, tafel);
                besteldeItemService.BestellingItemsAanmaken(bestelling);
                form1.SwitchPanels(new TafelStatusUI(tafel));
            }
        }

        private void ToevoegenEenAanBestelling(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if (listView.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;
                if (besteldeItem.menuItem.Voorraad > 0)
                {
                    besteldeItem.Hoeveelheid++;
                    besteldeItem.menuItem.Voorraad--;
                    VulListViewBestelling(listViewBestelling, bestelling);
                    VullenListView(listViewKaart, menu, menu.MenuType);
                }
                else
                {
                    MessageBox.Show("Er is geen voorraad voor dit menu item.");
                }
            }
        }

        private void VerwijderenEenAanBestelling(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if (listView.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;

                if (besteldeItem.Hoeveelheid == 1)
                {
                    besteldeItem.menuItem.Voorraad++;
                    bestelling.BestellingItems.Remove(besteldeItem);
                }
                else if (besteldeItem.Hoeveelheid > 0)
                {
                    besteldeItem.Hoeveelheid--;
                    besteldeItem.menuItem.Voorraad++;
                }
                else
                {
                    bestelling.BestellingItems.Remove(besteldeItem);
                }
                VulListViewBestelling(listViewBestelling, bestelling);
                VullenListView(listViewKaart, menu, menu.MenuType);
            }
        }

        private void RijVerwijderen(System.Windows.Forms.ListView listView, Bestelling bestelling, Menu menu)
        {
            if (listView.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;
                besteldeItem.menuItem.Voorraad += besteldeItem.Hoeveelheid;
                bestelling.BestellingItems.Remove(besteldeItem);
                listView.Items.Remove(listView.SelectedItems[0]);
                VullenListView(listViewKaart, menu, menu.MenuType);
            }
        }

        private void ToevoegenAanBestelling(Bestelling bestelling, Menu menu)
        {
            if (listViewKaart.SelectedItems.Count > 0)
            {
                MenuItem menuItem = (MenuItem)listViewKaart.SelectedItems[0].Tag;
                if (menuItem.Voorraad > 0)
                {
                    menuItem.Voorraad--;
                    BesteldeItem bestaandItem = bestelling.BestellingItems.FirstOrDefault(bi => bi.menuItem.Naam == menuItem.Naam);

                    if (bestaandItem != null)
                    {
                        bestaandItem.Hoeveelheid++;
                    }
                    else
                    {
                        BesteldeItem nieuwBesteldItem = new BesteldeItem(menuItem);
                        bestelling.BestellingItems.Add(nieuwBesteldItem);
                    }

                    VulListViewBestelling(listViewBestelling, bestelling);
                    VullenListView(listViewKaart, menu, menu.MenuType);
                }
                else
                {
                    MessageBox.Show("Er is geen voorraad voor dit menu item.");
                }
            }
        }

        private void ToevoegenOpmerkingAanBestelling(Bestelling bestelling)
        {
            if (listViewBestelling.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;
                besteldeItem.Opmerking = txtOpmerking.Text;
                VulListViewBestelling(listViewBestelling, bestelling);
            }
        }

        private void VerwijderAllesUitListView(Bestelling bestelling, Menu menu)
        {
            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                besteldeItem.menuItem.Voorraad += besteldeItem.Hoeveelheid;
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
                if ((MenuType)menuItem.MenuId == menu.MenuType)
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

            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                ListViewItem item = new ListViewItem(besteldeItem.menuItem.Naam);
                item.SubItems.Add(besteldeItem.menuItem.Prijs.ToString());
                item.SubItems.Add(besteldeItem.Hoeveelheid.ToString());
                item.SubItems.Add(besteldeItem.Opmerking);
                item.Tag = besteldeItem;
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
