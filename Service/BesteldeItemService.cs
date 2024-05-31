using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class BesteldeItemService
    {
        private BesteldeItemDao besteldeItemDao;

        public BesteldeItemService()
        {
            besteldeItemDao = new BesteldeItemDao();
        }
        public List<BesteldeItem> GetItemsFromBestelling(int bestellingID)
        {
            return besteldeItemDao.GetItemsFromBestelling(bestellingID);

        }
    }
}
