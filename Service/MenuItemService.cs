﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
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
        // Lucas
        public List<MenuItem> GetMenuItemsByMenu(MenuType menuType)
        {
            return menuItemDao.GetMenuItemsByMenuId(menuType);
        }
        public MenuItem CreateMenuItem(string name, double price, bool alcoholic, MenuType menuId, int stock)
        {
            if (stock <= 0 || price <= 0)
            {
                throw new FormatException("Mag geen 0 zijn");
            }
            return new MenuItem(name, price, alcoholic, menuId, stock);
        }
        public void AddNewMenuItem(MenuItem newMenuItem)
        {
            menuItemDao.AddNewMenuItem(newMenuItem);
        }
        public void UpdateMenuItemStock(MenuItem selectedMenuItem)
        {
            menuItemDao.UpdateMenuItemStock(selectedMenuItem);
        }
        public void DeleteMenuItem(MenuItem selectedMenuItem) 
        {
            menuItemDao.DeleteMenuItem(selectedMenuItem);
        }

        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            menuItemDao.UpdateAllMenuItemsStock(bestelling);
        }
        //public List<MenuItem> GetAllMenuItems(MenuType menuType)
        //{
        //    List<MenuItem> selectedMenu = new List<MenuItem>();
        //    foreach (MenuItem menuItem in menuItemDao.GetAllMenuItems())
        //    {
        //        if (menuItem.MenuId == (int)menuType)
        //        {
        //            selectedMenu.Add(menuItem);
        //        }
        //    }
        //    return selectedMenu;
        //}
    }
}
