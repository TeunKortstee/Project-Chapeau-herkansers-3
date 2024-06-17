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
        public List<ItemBereider> GetAllItems(int personelId)
        {
            return itemBereiderDao.GetAllItems(personelId);
        }

        public List<Bestelling> GetTafelBestelling(Tafel tafel, string ItemBereider)
        {
            return itemBereiderDao.GetTafelBestelling(tafel, ItemBereider);
        }
        public void ChangeStatus(Bestelling bestelling, string ItemBereider)
        {
            itemBereiderDao.ChangeStatus(bestelling, ItemBereider);
        }
    }
}
