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
        public int AddNewMenuItem(MenuItem newMenuItem)
        {
            return menuItemDao.AddNewMenuItem(newMenuItem);
        }
        public void UpdateMenuItem(MenuItem selectedMenuItem)
        {
            menuItemDao.UpdateMenuItem(selectedMenuItem);
        }
        public void UpdateMenuItemStock(MenuItem selectedMenuItem)
        {
            menuItemDao.UpdateMenuItemStock(selectedMenuItem);
        }
        public void SoftDeleteMenuItem(MenuItem selectedMenuItem) 
        {
            menuItemDao.SoftDeleteMenuItem(selectedMenuItem);
        }
        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            menuItemDao.UpdateAllMenuItemsStock(bestelling);
        }
    }
}
