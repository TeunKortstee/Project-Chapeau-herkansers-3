using DAL;
using Model;


namespace Service
{
    public class BetalingService
    {
        private BetalingDao betalingDao;
        private RekeningDao rekeningDao;
        private const double vatNormal = 0.06;
        private const double vatAlcohol = 0.21;


        public BetalingService()
        {
            betalingDao = new BetalingDao();
            rekeningDao = new RekeningDao();

        }

        public double AddDoubleArray(double[] array)
        {

            double result = 0.00;
            foreach (double d in array)
            {
                result += d;

            }
            return result;
        }
        public double[] GetTipPerPerson(int people)
        {
            double[] tips = new double[people];
            for (int i = 0; i < people; i++)
            {
                tips[i] = 0.00;


            }
            return tips;
        }

        public double CalculateChange(double toPay, double amountPaid)
        {



            return amountPaid - toPay;


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

                payments[0] = Math.Round(division + remainder, 2, MidpointRounding.ToEven);
            }




            return payments;

        }




        public int ConfirmPayments(Rekening bill, List<SplitBillItemObj> payments)
        {


            double totalAmountPaid = 0.00;

            List<Betaling> betalingen = new List<Betaling>();

            foreach (SplitBillItemObj payment in payments)
            {

                if (payment.payment > 0 && payment.tip >= 0)
                {
                    totalAmountPaid += payment.payment;
                    betalingen.Add(new Betaling(0, (int)payment.method, payment.payment, bill.RekeningId, payment.tip));

                }
                else
                {
                    return 1;

                }
            }



            if (totalAmountPaid >= bill.TotaalPrijs)
            {
                // Succes!
                foreach (Betaling betaling in betalingen)
                {
                    //betalingDao.InsertBetaling(betaling);



                }

                rekeningDao.RekeningBetaald(bill);

                return 2;

            }


            return 0;


        }



    }





}
