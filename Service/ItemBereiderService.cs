using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
