using DAL;
using Model;

namespace Service
{
    public class MenuItemService
    {
        private MenuDao menuItemDao;

        public MenuItemService()
        {
            menuItemDao = new MenuDao();
        }
        public Menu GetAllMenuItemsInMenu()
        {
            return menuItemDao.GetAllMenuItemsInMenu();
        }
        // Lucas
        public Menu GetAllMenuItemsByMenuType(MenuType menuType)
        {
            return menuItemDao.GetAllMenuItemsByMenuType(menuType);
        }
        public void AddNewMenuItem(MenuItem newMenuItem)
        {
            menuItemDao.AddNewMenuItem(newMenuItem);
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
        public int GetMenuItemSales(MenuItem menuItem, DateTime datumVan, DateTime datumTot)
        {
            return menuItemDao.GetMenuItemSales(menuItem, datumVan, datumTot);
        }
        // Luciano
        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            menuItemDao.UpdateAllMenuItemsStock(bestelling);
        }
    }
}
