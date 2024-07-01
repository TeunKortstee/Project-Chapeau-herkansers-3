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
        private BetalingDao betalingDao;
        private BelastingService belastingService;
        public RekeningService()
        {
            rekeningDao = new RekeningDao();
            bestellingDao = new BestellingDao();
            betalingDao = new BetalingDao();
            belastingService = new BelastingService();
        }
        public int InsertRekening(Rekening rekening)
        {
            return rekeningDao.InsertRekening(rekening);
        }
        public Rekening MaakRekeningObject(Tafel tafel)
        {
            List<Bestelling> bestellingen = bestellingDao.GetBestellingen(tafel.Id);
            double totaalPrijs = 0.00;
            double belastingNormaal = 0.00;
            double belastingAlcoholisch = 0.00;
            foreach (Bestelling bestelling in bestellingen)
            {
                foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
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
        public double[] GetPaymentPerPerson(double price, int people)
        {
            double[] payments = new double[people];
            double division = Math.Round(price / people, 2, MidpointRounding.ToZero);
            for (int i = 0; i < people; i++)
            {
                payments[i] = division;
            }
            // Voor als er door een oneven getal word gedeeld
            if (division * people < price)
            {
                double remainder = price - division;
                payments[0] += remainder;
            }
            return payments;
        }
        public void VoegOpmerkingenToe(Rekening rekening, string opmerkingen) {
            rekening.Opmerkingen = opmerkingen;   
        }        
        public void BetaalRekening(Rekening rekening) {
            // Voeg fooi aan btw toe
            belastingService.BetaalBelastingOverFooi(rekening);
            int rekeningID = InsertRekening(rekening);
            betalingDao.InsertBetalingen(rekening.Betalingen);                  
        }
    }
}
