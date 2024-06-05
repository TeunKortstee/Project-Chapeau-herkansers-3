using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BesteldeItemService
    {
        private BesteldeItemDao besteldeItemDao;

        public BesteldeItemService()
        {
            besteldeItemDao = new BesteldeItemDao();
        }
        //public List<BesteldItem> GetItemsFromBestelling(int bestellingID)
        //{
        //    return besteldeItemDao.GetItemsFromBestelling(bestellingID);

        //}

        public void BestellingAanmaken(Bestelling bestelling)
        {
            besteldeItemDao.BestellingAanmaken(bestelling);
        }
    }
}
