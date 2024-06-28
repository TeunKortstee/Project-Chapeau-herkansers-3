using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            Bestelling bestelling = new Bestelling(tafel);
            buttonsVullen(menu, bestelling, menuItemService);
            VulTekstTafel(tafel);
            VulListMetColumns();
        }

        private void buttonsVullen(Menu menu, Bestelling bestelling, MenuItemService menuItemService)
        {
            btnLunchKaart.Click += (sender, e) => ListViewLunchKaartLatenZien(menu);
            btnDinerKaart.Click += (sender, e) => ListViewDinerKaartLatenZien(menu);
            btnDrankKaart.Click += (sender, e) => ListViewDrankKaartLatenZien(menu);
            btnToevoegenBestelling.Click += (sender, e) => ToevoegenAanBestelling(bestelling, menu);
            btnOpmerking.Click += (sender, e) => ToevoegenOpmerkingAanBestelling(bestelling);
            btnVerwijderAlles.Click += (sender, e) => VerwijderAllesUitListView(bestelling, menu);
            btnRijVerwijderen.Click += (sender, e) => RijVerwijderen(bestelling, menu);
            btnToevoegenEen.Click += (sender, e) => ToevoegenEenAanBestelling(bestelling, menu);
            btnVerwijderEen.Click += (sender, e) => VerwijderenEenAanBestelling(bestelling, menu);
            btnAfrekenen.Click += (sender, e) => AfrekenenBestelling(bestelling, menuItemService);
        }

        private void ListViewLunchKaartLatenZien(Menu menu)
        {
            menu.MenuType = MenuType.Lunch;
            VullenListView(menu);
        }

        private void ListViewDinerKaartLatenZien(Menu menu)
        {
            menu.MenuType = MenuType.Diner;
            VullenListView(menu);
        }

        private void ListViewDrankKaartLatenZien(Menu menu)
        {
            menu.MenuType = MenuType.Drank;
            VullenListView(menu);
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

        private void AfrekenenBestelling(Bestelling bestelling, MenuItemService menuItemService)
        {
            if(listViewBestelling.Items.Count > 0)
            {
                BesteldeItemService besteldeItemService = new BesteldeItemService();
                besteldeItemService.BestellingEnBesteldeItemsAanmaken(bestelling);
                menuItemService.UpdateAllMenuItemsStock(bestelling);
                TafelStatusUI tafelStatusUI = new TafelStatusUI(bestelling.tafel);
                tafelStatusUI.SetStringName("Bestelling succesvol aangemaakt");
                Form1 form1 = Form1.Instance;
                form1.SwitchPanels(tafelStatusUI);
            }
        }

        private void ToevoegenEenAanBestelling(Bestelling bestelling, Menu menu)
        {
            if (listViewBestelling.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;
                if (besteldeItem.menuItem.Voorraad > 0)
                {
                    besteldeItem.Hoeveelheid++;
                    besteldeItem.menuItem.Voorraad--;
                    VulListViewBestelling(bestelling);
                    VullenListView(menu);
                }
                else
                {
                    MessageBox.Show("Er is geen voorraad voor dit menu item.");
                }
            }
        }

        private void VerwijderenEenAanBestelling(Bestelling bestelling, Menu menu)
        {
            if (listViewBestelling.SelectedItems.Count > 0)
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
                VulListViewBestelling(bestelling);
                VullenListView(menu);
            }
        }

        private void RijVerwijderen(Bestelling bestelling, Menu menu)
        {
            if (listViewBestelling.SelectedItems.Count > 0)
            {
                BesteldeItem besteldeItem = (BesteldeItem)listViewBestelling.SelectedItems[0].Tag;
                besteldeItem.menuItem.Voorraad += besteldeItem.Hoeveelheid;
                bestelling.BestellingItems.Remove(besteldeItem);
                listViewBestelling.Items.Remove(listViewBestelling.SelectedItems[0]);
                VullenListView(menu);
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

                    VulListViewBestelling(bestelling);
                    VullenListView(menu);
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
                VulListViewBestelling(bestelling);
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
            VullenListView(menu);
        }

        private void VullenListView(Menu menu)
        {
            listViewKaart.Items.Clear();

            foreach (MenuItem menuItem in menu.MenuItems)
            {
                if ((MenuType)menuItem.menuType == menu.MenuType)
                {
                    ListViewItem item = new ListViewItem(menuItem.Naam);
                    item.SubItems.Add(menuItem.Prijs.ToString());
                    item.SubItems.Add(menuItem.Voorraad.ToString());
                    item.Tag = menuItem;
                    listViewKaart.Items.Add(item);
                }
            }
        }

        private void VulListViewBestelling(Bestelling bestelling)
        {
            listViewBestelling.Items.Clear();

            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                ListViewItem item = new ListViewItem(besteldeItem.menuItem.Naam);
                item.SubItems.Add(besteldeItem.menuItem.Prijs.ToString());
                item.SubItems.Add(besteldeItem.Hoeveelheid.ToString());
                item.SubItems.Add(besteldeItem.Opmerking);
                item.Tag = besteldeItem;
                listViewBestelling.Items.Add(item);
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
