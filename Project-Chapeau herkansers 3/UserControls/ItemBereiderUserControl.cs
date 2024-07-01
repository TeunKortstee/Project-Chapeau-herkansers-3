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

namespace Project_Chapeau_herkansers_3.UserControls
{
    public partial class ItemBereiderUserControl : UserControl
    {
        ItemBereiderService _itemBereiderService;
        public ItemBereiderUserControl()
        {
            InitializeComponent();
            _itemBereiderService = new ItemBereiderService();
        }

        private void OrdersListView()
        {
            var orderItems = _itemBereiderService.GetAllBesteldeItems();
            orderListView.Items.Clear();
            foreach (var item in orderItems)
            {
                ListViewItem li = new ListViewItem(item.BesteldItemId.ToString());
                li.Tag = item;
                li.SubItems.Add(item.BesteldItemId.ToString());
                li.SubItems.Add(item.Hoeveelheid.ToString());
                li.SubItems.Add(item.Opmerking);
                orderListView.Items.Add(li);
            }
        } 

        private void UpdateOrderStatus(GerechtsStatus status)
        {
            foreach (ListViewItem item in orderListView.SelectedItems)
            {
                BesteldeItem items = (BesteldeItem)item.Tag;
                items.UpdateOrderStatus(status);
                _itemBereiderService.UpdateBestellingStatus(status, items.BesteldItemId);
            }
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
        }

        private void ItemBereiderUserControl_Load(object sender, EventArgs e)
        {
            OrdersListView();
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
