using DAL;
using Model;

namespace Service
{
    public class MenuItemService
    {
        const string DatabaseExceptionText = "Er ging iets mis";
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
            try
            {
                menuItemDao.AddNewMenuItem(newMenuItem);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public void UpdateMenuItem(MenuItem selectedMenuItem)
        {
            try
            {
                menuItemDao.UpdateMenuItem(selectedMenuItem);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public void UpdateMenuItemStock(MenuItem selectedMenuItem)
        {
            try
            {
                menuItemDao.UpdateMenuItemStock(selectedMenuItem);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public void SoftDeleteMenuItem(MenuItem selectedMenuItem) 
        {
            try
            {
                menuItemDao.SoftDeleteMenuItem(selectedMenuItem);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
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
