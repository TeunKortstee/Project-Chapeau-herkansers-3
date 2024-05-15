using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace Service
{
    public class MenuItemService
    {
        private MenuItemDao menuItemDao;

        public MenuItemService()
        {
            menuItemDao = new MenuItemDao();
        }


    }
}
