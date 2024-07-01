using Model;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class ItemBereiderUserControl : UserControl
    {
        ItemBereiderService _itemBereiderService;
        List<BesteldeItem> keukenItems;
        List<BesteldeItem> barItems;
        public ItemBereiderUserControl()
        {
            InitializeComponent();
            _itemBereiderService = new ItemBereiderService();
            keukenItems = new List<BesteldeItem>();
            barItems = new List<BesteldeItem>();
            divideBarItems();
            OrdersListView(true);
        }

        private void OrdersListView(bool isKeuken)
        {
            orderListView.Items.Clear();
            if (isKeuken)
            {
                foreach (BesteldeItem keukenitem in keukenItems)
                {
                    AddItemToView(keukenitem);
                }
            }
            else
            {
                foreach (BesteldeItem barItem in barItems)
                {
                    AddItemToView(barItem);
                }
            }
        }

        private void AddItemToView(BesteldeItem item)
        {
            if (item.Status != GerechtsStatus.Served)
            {
                ListViewItem li = new ListViewItem(item.BesteldItemId.ToString());
                li.Tag = item;
                li.SubItems.Add(item.Hoeveelheid.ToString());
                li.SubItems.Add(item.Opmerking);
                orderListView.Items.Add(li);
            }
        }

        private void divideBarItems()
        {
            List<BesteldeItem> orderItems = _itemBereiderService.GetAllBesteldeItems();

            foreach (BesteldeItem item in orderItems)
            {
                if (item.menuItem.MenuType == MenuType.Drank)
                {
                    barItems.Add(item);
                }

                else
                {
                    keukenItems.Add(item);
                }
            }
        }

        private void UpdateOrderStatus(GerechtsStatus status)
        {
            foreach (ListViewItem listViewItem in orderListView.SelectedItems)
            {
                if (listViewItem.Tag is BesteldeItem besteldeItem)
                {
                    if (status == GerechtsStatus.Served && besteldeItem.Status != GerechtsStatus.Prepared)
                    {
                        MessageBox.Show(
                            "Een item moet de status 'Prepared' hebben voordat het als 'Served' kan worden gemarkeerd.",
                            "Statusfout",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    besteldeItem.UpdateOrderStatus(status);
                    _itemBereiderService.UpdateBestellingStatus(status, besteldeItem.BesteldItemId);

                    if (status == GerechtsStatus.Served)
                    {
                        orderListView.Items.Remove(listViewItem);
                    }
                }
            }

            UpdateOrderInformation();
        }

        private void InPreparationBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.InPreparation);
        }

        private void PreparedBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.Prepared);
        }

        private void ServedButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.Served);
            InkomenService inkomenService = new InkomenService();
            inkomenService.UpdateInkomen(besteldeItem);
        }

        private void ItemBereiderUserControl_Load(object sender, EventArgs e)
        {
            //OrdersListView(true);
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderInformation();
        }

        public void UpdateOrderInformation()
        {
            if (orderListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = orderListView.SelectedItems[0];
                BesteldeItem selectedModel = selectedItem.Tag as BesteldeItem;
                informationTextBox.Font = new Font(informationTextBox.Font.FontFamily, 12);
                informationTextBox.Text = $@"
                OrderId: {selectedModel.BesteldItemId}
                Status: {selectedModel.Status}
                Naam: {selectedModel.Naam}
                Hoeveelheid: {selectedModel.Hoeveelheid}
                Opmerking: {selectedModel.Opmerking}
                Instuurtijd: {selectedModel.InstuurTijd}
                ";
            }
        }

        private void BarButton_Click(object sender, EventArgs e)
        {
            OrdersListView(false);
        }

        private void KeukenButton_Click(object sender, EventArgs e)
        {
            OrdersListView(true);
        }
    }
}
