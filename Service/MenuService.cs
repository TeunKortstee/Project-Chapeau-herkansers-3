using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MenuService
    {
        private MenuDao menuDao;

        public MenuService()
        {
            this.menuDao = new MenuDao();
        }
    }
}
