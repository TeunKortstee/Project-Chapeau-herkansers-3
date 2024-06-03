using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class MenuItemService
    {
        private MenuItemDao menuItemDao;

        public MenuItemService()
        {
            menuItemDao = new MenuItemDao();
        }

        //public MenuItem GetById(int id)
        //{
        //    return menuItemDao.GetById(id);
        //}
        //public List<MenuItem> GetByItemType(ItemType itemType, int menuId)
        //{
        //    return menuItemDao.GetByItemType(itemType, menuId);
        //}

        public Menu GetAllItems()
        {
            return menuItemDao.GetAllItems();
        }
        public MenuItem CreateMenuItem(string name, decimal price, bool alcoholic, int menuId, int stock)
        {
            return new MenuItem(name, price, alcoholic, menuId, stock);
        }
        public void AddMenuItem(MenuItem newMenuItem)
        {
            menuItemDao.InsertMenuItem(newMenuItem);
        }
        public void RemoveMenuItem(int menuItemId) 
        {
            menuItemDao.DeleteMenuItem(menuItemId);
        }

    }
}
