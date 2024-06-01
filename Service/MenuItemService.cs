using System;
using System.Collections.Generic;
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
        public List<MenuItem> GetMenuItemsByMenu(MenuType menuType)
        {
            return menuItemDao.GetMenuItemsByMenu(menuType);
        }

    }
}
