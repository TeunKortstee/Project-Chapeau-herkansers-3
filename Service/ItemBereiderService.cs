using DAL;
using Model;

namespace Service
{
    public class ItemBereiderService
    {
        private ItemBereiderDao itemBereiderDao;

        public ItemBereiderService()
        {
            itemBereiderDao = new ItemBereiderDao();
        }
        public List<BesteldeItem> GetAllBesteldeItems()
        {
            return itemBereiderDao.GetAllBesteldeItems();
        }
        public void UpdateBestellingStatus(GerechtsStatus status, int besteldeItemId)
        {
            itemBereiderDao.UpdateBestellingStatus(status, besteldeItemId);
        }
        public List<Bestelling> GetTafelBestelling(Tafel tafel, string ItemBereider)
        {
            if (ItemBereider == "Keuken")
            {
                return itemBereiderDao.GetTafelBestellingKeuken(tafel);
            }
            else if (ItemBereider == "Bar")
            {
                return itemBereiderDao.GetTafelBestellingBar(tafel);
            }
            return null;
        }
        public void ChangeStatus(Bestelling bestelling, string ItemBereider)
        {
            if (ItemBereider == "Keuken")
            {
                itemBereiderDao.ChangeKeukenStatus(bestelling);
            }
            else if (ItemBereider == "Bar")
            {
                itemBereiderDao.ChangeBarStatus(bestelling);
            }
        }
    }
}
