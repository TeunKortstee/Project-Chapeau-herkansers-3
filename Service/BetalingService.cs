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
        private const double vatNormal = 0.06;
        private const double vatAlcohol = 0.21;


        public BetalingService()
        {
            betalingDao = new BetalingDao();

        }

        public double AddDoubleArray(double[] array) {

            double result = 0.00;
            foreach (double d in array) {
                result += d;
            
            }
            return result;
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
            double remainder = price - (division * people);
            if (remainder > 0)
            {
                
                payments[0] = Math.Round(division+remainder,2,MidpointRounding.ToEven);
            }




            return payments;

        }



    }


        
    

}
