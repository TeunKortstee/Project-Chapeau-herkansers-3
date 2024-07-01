using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private BetalingDao betalingDao;
        private BelastingService belastingService;
        private BetalingService betalingService;
        public RekeningService()
        {
            rekeningDao = new RekeningDao();
            bestellingDao = new BestellingDao();
            betalingDao = new BetalingDao();
            belastingService = new BelastingService();
            betalingService = new BetalingService();
        }
        public int InsertRekening(Rekening rekening)
        {
            return rekeningDao.InsertRekening(rekening);
        }
        public Rekening MaakRekeningObject(Tafel tafel)
        {
            List<Bestelling> bestellingen = bestellingDao.GetBestellingen(tafel);
            double totaalPrijs = 0.00;
            double belastingNormaal = 0.00;
            double belastingAlcoholisch = 0.00;
            foreach (Bestelling bestelling in bestellingen)
            {
                foreach (BesteldeItem besteldeItem in bestelling.BesteldeItems)
                {
                    totaalPrijs += besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid;
                }
                double[] belastingCategorieen = belastingService.BerekenBelasting(bestelling);
                belastingNormaal += belastingCategorieen[0];
                belastingAlcoholisch += belastingCategorieen[1];
            }
            Rekening rekening = new Rekening(bestellingen, tafel, totaalPrijs, belastingNormaal, belastingAlcoholisch);
            return rekening;
        }
        public List<Rekening> GetBetaaldeRekeningen(bool betaald)
        {
            return rekeningDao.GetBetaaldeRekeningen(betaald);
        }
        public double[] KrijgBetalingPerPersoon(double prijs, int mensen)
        {
            return betalingService.KrijgBetalingPerPersoon(prijs,mensen);
        }
        public void VoegOpmerkingenToe(Rekening rekening, string opmerkingen) {
            rekening.Opmerkingen = opmerkingen;   
        }        
        public void BetaalRekening(Rekening rekening) {
            // Voeg fooi aan btw toe
            belastingService.BetaalBelastingOverFooi(rekening);
            int rekeningID = InsertRekening(rekening);
            rekening.RekeningId = rekeningID;
            betalingDao.InsertBetalingen(rekening.Betalingen);                  
        }
    }
}
