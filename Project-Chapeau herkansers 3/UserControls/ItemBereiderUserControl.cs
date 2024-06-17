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
        public ItemBereiderUserControl()
        {
            InitializeComponent();
            _itemBereiderService = new ItemBereiderService();
        }

        private void OrdersListView()
        {
            //waarom zoveel duplicate items
            var orderItems = _itemBereiderService.GetAllItems(_personId);
            orderListView.Items.Clear();
            foreach (var item in orderItems)
            {
                ListViewItem li = new ListViewItem(item.BesteldItemId.ToString());
                li.Tag = item;
                li.SubItems.Add(item.BestellingsId.ToString());
                li.SubItems.Add(item.Hoeveelheid.ToString());
                li.SubItems.Add(item.Opmerking?.ToString());
                orderListView.Items.Add(li);
            }
        }

        private void UpdateOrderStatus(GerechtsStatus status)
        {

        }


        private void InPreparationButton_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(GerechtsStatus.InPreparation);
        }

        private void preparedButton_Click(object sender, EventArgs e)
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
                ItemBereider selectedModel = selectedItem.Tag as ItemBereider;
                //                informationTextBox.Text = $@"Id: {selectedModel.BestellingsId}
                //Status: {selectedModel.Status}
                //Naam: {selectedModel.Naam}
                //Voorraad: {selectedModel.Voorraad}       
                //MenuItemId: {selectedModel.MenuItemId}
                //Hoeveelheid: {selectedModel.Hoeveelheid}
                //Alcoholisch: {selectedModel.Alcoholisch}
                //Opmerking: {selectedModel.Opmerking}
                //InstuutTijd: {selectedModel.Instuurtijd}
                //";
                informationTextBox.Text = $@"
                OrderId: {selectedModel.BestellingsId}
                Status: {selectedModel.Status}
                Naam: {selectedModel.Naam}
                Hoeveelheid: {selectedModel.Hoeveelheid}
                Alcoholisch: {selectedModel.Alcoholisch}
                Opmerking: {selectedModel.Opmerking}
                Instuurtijd: {selectedModel.Instuurtijd}
                ";


                // alcoholisch mag mischien ook wel weg
            }

        }
    }
}
