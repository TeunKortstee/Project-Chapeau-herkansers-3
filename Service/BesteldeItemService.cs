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
        public List<BesteldeItem> GetItemsFromBestelling(Bestelling bestelling)
        {
            return besteldeItemDao.GetItemsFromBestelling(bestelling);

        }

        public void BestellingEnBesteldeItemsAanmaken(Bestelling bestelling)
        {
            besteldeItemDao.BestellingEnBesteldeItemsAanmaken(bestelling);
        }
    }
}