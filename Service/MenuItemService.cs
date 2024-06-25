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
    }
}
