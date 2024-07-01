using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;


namespace Service
{
    public class BetalingService
    {
        private BetalingDao betalingDao;
        private RekeningDao rekeningDao;       
        public BetalingService()
        {
            betalingDao = new BetalingDao();
            rekeningDao = new RekeningDao();

        }
        public double VoegDoublesBijElkaar(double[] doubleArray) 
        {
            double resultaat = 0.00;
            foreach (double doubleItem in doubleArray) {
                resultaat += doubleItem;            
            }
            return resultaat;
        }
        public double[] KrijgGesplitsteFooi(int hoeveelheidMensen)
        {
            double[] fooiLijst = new double[hoeveelheidMensen];
            for (int i = 0; i < hoeveelheidMensen; i++)
            {
                fooiLijst[i] = 0.00;
            }
            return fooiLijst;
        }
        public double BerekenWisselgeld(double teBetalen, double betaald) 
        {
            return betaald - teBetalen;
        }
        public double[] KrijgBetalingPerPersoon(double prijs, int mensen)
        {
            double[] betalingen = new double[mensen];
            double deling = Math.Round(prijs / mensen, 2, MidpointRounding.ToZero);
            for (int i = 0; i < mensen; i++)
            {
                betalingen[i] = deling;
            }
            // Voor als er door een oneven getal word gedeeld
            double rest = prijs - (deling * mensen);
            if (rest > 0)
            {                
                betalingen[0] = Math.Round(deling+rest,2,MidpointRounding.ToEven);
            }
            return betalingen;
        }
        public int BevestigBetalingen(Rekening rekening, List<GesplitsteRekeningObject> gesplitsteRekeningObjecten) 
        {
            double totaalHoeveelheidBetaald = 0.00;
            List<Betaling> betalingen = new List<Betaling>();            
            foreach (GesplitsteRekeningObject betaling in gesplitsteRekeningObjecten) {
                if (betaling.betaling > 0 && betaling.fooi >= 0) {
                    totaalHoeveelheidBetaald += betaling.betaling;                    
                    betalingen.Add(new Betaling(0, (int)betaling.betaalMethode, betaling.betaling, betaling.fooi,rekening));                    
                } else {
                    return 1;
                }
            }
            if (totaalHoeveelheidBetaald >= rekening.TotaalPrijs) {
                // Succes!
                rekening.Betalingen = betalingen;                
                return 2;
            }
            return 0;
        }
        public List<Betaling> GetBetalingen(bool betaald)
        {
            return betalingDao.GetBetalingen(betaald);
        }
    }
}