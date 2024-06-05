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

        public Bestelling BestellingAanmaken(Bestelling bestelling, Personeel personeel)
        {
            return besteldeItemDao.BestellingAanmaken(bestelling, personeel);
        }

        public void BestellingItemsAanmaken(Bestelling bestelling)
        {
            besteldeItemDao.BestellingItemsAanmaken(bestelling);
        }
    }
}
