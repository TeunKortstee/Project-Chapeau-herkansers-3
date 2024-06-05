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
        const double vatNormal = 0.06;
        const double vatAlcohol = 0.21;
        public Bestelling bestelling;

        public Afrekenen(Bestelling _bestelling)
        {
            InitializeComponent();
            serviceMI = new MenuItemService();
            serviceBI = new BesteldeItemService();
            menuItems = serviceMI.GetAllItems();
            bestelling = _bestelling;
            RefreshBillItems();


        }

        public void RefreshBillItems()
        {
            List<BesteldeItem> besteldeItems = serviceBI.GetItemsFromBestelling(bestelling.Id);
            billListView.Items.Clear();
            double total = 0.00;
            double vat = 0.00;
            foreach (BesteldeItem b in besteldeItems)
            {

                ListViewItem item = new ListViewItem(b.Hoeveelheid + "x");

                item.SubItems.Add(menuItems.MenuItems[b.MenuItemID].Naam);
                item.SubItems.Add("€ " + (menuItems.MenuItems[b.MenuItemID].Prijs * b.Hoeveelheid));
                billListView.Items.Add(item);
                if (b.Opmerking != null && b.Opmerking != "")
                {
                    ListViewItem comment = new ListViewItem("");
                    comment.SubItems.Add(b.Opmerking + "");
                    comment.ForeColor = Color.Gray;
                    Font commentFont = new Font(comment.Font, FontStyle.Italic);

                    comment.Font = commentFont;
                    billListView.Items.Add(comment);

                }

                double itemTotal = (menuItems.MenuItems[b.MenuItemID].Prijs * b.Hoeveelheid);
                total += itemTotal;
                if (menuItems.MenuItems[b.MenuItemID].IsAlcoholisch)
                {
                    vat += itemTotal * vatAlcohol;

                }
                else
                {
                    vat += itemTotal * vatNormal;
                }



            }
            billTotalAmountText.Text = "€ " + total;
            totalVatPriceLabel.Text = "€ " + vat;
        }

    }
}
