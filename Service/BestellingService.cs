using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class BestellingService
    {
        private BestellingDao bestellingDao;

        public BestellingService()
        {
            bestellingDao = new BestellingDao();
        }
        public List<Bestelling> GetBestellingen(Tafel tafel)
        {
            return bestellingDao.GetBestellingen(tafel);

        }        
    }
}
