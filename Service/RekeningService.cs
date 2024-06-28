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
        private const double vatNormal = 0.06;
        private const double vatAlcohol = 0.21;


        public RekeningService()
        {
            rekeningDao = new RekeningDao();
            bestellingDao = new BestellingDao();
        }
        public Rekening GetRekening(int bestellingID)
        {
            return rekeningDao.GetRekening(bestellingID);

        }
        public int InsertRekening(Rekening rekening)
        {

            return rekeningDao.InsertRekening(rekening);
        }


        public static double BerekenBelasting(BesteldeItem b) {

            double itemTotal = (b.menuItem.Prijs * b.Hoeveelheid);

            if (b.menuItem.IsAlcoholisch)
            {
                return itemTotal * vatAlcohol;

            }
            return itemTotal * vatNormal;




        }



        public Rekening CreateRekening(Tafel tafel) {

            Rekening r = new Rekening();
            List<Bestelling> bestellingen = bestellingDao.GetBestellingen(tafelID);
            if (r == null) {

                double totaalPrijs = 0.00;
                double belasting = 0.00;





                foreach (Bestelling bestelling in bestellingen) {

                    foreach (BesteldeItem besteldeItem in bestelling.BestellingItems) {

                        totaalPrijs += besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid;
                        belasting += BerekenBelasting(besteldeItem);




                    }
                }

                r = new Rekening(0, tafelID, totaalPrijs, false, DateTime.Now, belasting,"");

                int ID = InsertRekening(r);

                r.RekeningId = ID;
            }

            r.Bestellingen = bestellingen;
            return r;

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
        public void VoegOpmerkingenToe(Rekening rekening, string opmerkingen)
        {
            rekeningDao.VoegOpmerkingenToe(rekening, opmerkingen);

        }


    }


        
    

}
