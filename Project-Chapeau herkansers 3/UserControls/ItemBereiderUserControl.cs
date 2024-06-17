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
        private int _personId = 0;
        ItemBereiderService _itemBereiderService;
        public ItemBereiderUserControl(int personId)
        {
            InitializeComponent();
            _itemBereiderService = new ItemBereiderService();
            _personId = personId;
        }

        private void OrdersListView()
        {
            var orderItems = _itemBereiderService.GetAllItems(_personId);
            orderListView.Items.Clear();
            foreach (var item in orderItems)
            {
                ListViewItem li = new ListViewItem(item.BesteldItemId.ToString());
                li.Tag = item;
                li.SubItems.Add(item.BesteldItemId.ToString());
                li.SubItems.Add(item.Hoeveelheid.ToString());
                li.SubItems.Add(item.Opmerking?.ToString());
                orderListView.Items.Add(li);
            }
        }

        private void UpdateOrderStatus(GerechtsStatus status)
        {
            foreach (ListViewItem item in orderListView.SelectedItems)
            {
                BesteldeItem items = (BesteldeItem)item.Tag;
                items.status = status;
                _itemBereiderService.UpdateStatus(status, items.BesteldItemId);
            }
        }

        private void InPreparationBtn_Click_1(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.InPreparation);

        }

        private void PreparedBtn_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.Prepared);
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
                informationTextBox.Text = $@"
                OrderId: {selectedModel.BesteldItemId}
                Status: {selectedModel.status}
                Naam: {selectedModel.Naam}
                Hoeveelheid: {selectedModel.Hoeveelheid}
                Opmerking: {selectedModel.Opmerking}
                Instuurtijd: {selectedModel.InstuurTijd}
                ";
            }

        }

        
    }
}
