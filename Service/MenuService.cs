using DAL;
using Model;

namespace Service
{
    // naar MenuService
    public class MenuItemService
    {
        const string DatabaseExceptionText = "Er ging iets mis";
        private MenuDao menuDao;

        public MenuItemService()
        {
            menuDao = new MenuDao();
        }
        public Menu GetAllMenuItemsInMenu()
        {
            return menuDao.GetAllMenuItemsInMenu();
        }
        // Lucas
        public Menu GetAllMenuItemsByMenuType(MenuType menuType)
        {
            return menuDao.GetMenuByMenuType(menuType);
        }
        public void AddNewMenuItem(MenuItem newMenuItem)
        {
            try
            {
                menuDao.AddNewMenuItem(newMenuItem);
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
                menuDao.UpdateMenuItem(selectedMenuItem);
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
                menuDao.UpdateMenuItemStock(selectedMenuItem);
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
                menuDao.SoftDeleteMenuItem(selectedMenuItem);
            }
            catch
            {
                throw new Exception(DatabaseExceptionText);
            }
        }
        public int GetMenuItemSales(MenuItem menuItem, DateTime datumVan, DateTime datumTot)
        {
            return menuDao.GetMenuItemSales(menuItem, datumVan, datumTot);
        }
        // Luciano
        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            menuDao.UpdateAllMenuItemsStock(bestelling);
        }
    }
}
