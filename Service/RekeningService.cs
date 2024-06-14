using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class RekeningService
    {
        private RekeningDao rekeningDao;
        private BestellingDao bestellingDao;
        private BesteldeItemDao besteldeItemDao;

        public RekeningService()
        {
            rekeningDao = new RekeningDao();
            bestellingDao = new BestellingDao();
            besteldeItemDao = new BesteldeItemDao();
        }
        public Rekening GetRekening(int bestellingID)
        {
            return rekeningDao.GetRekening(bestellingID);

        }
        public int InsertRekening(Rekening rekening)
        {

            return rekeningDao.InsertRekening(rekening);
        }


       public Rekening CreateRekening(int tafelID) {

            Rekening? r = rekeningDao.GetRekening(tafelID);
            List<Bestelling> bestellingen = bestellingDao.GetBestellingen(tafelID);
            if (r == null) {
                
                double totaalPrijs = 0.00;

                




                foreach (Bestelling bestelling in bestellingen) {

                    foreach (BesteldeItem besteldeItem in bestelling.BestellingItems) {

                        totaalPrijs += besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid;



                    }
                }

                r = new Rekening(0, tafelID, totaalPrijs, false, DateTime.Now);
               
                InsertRekening(r);
            }
            r.Bestellingen = bestellingen;
            return r;
        
        }

        public List<Rekening> GetBetaaldeRekeningen(bool betaald)
        {
            return rekeningDao.GetBetaaldeRekeningen(betaald);
        }
    }


        
    

}
