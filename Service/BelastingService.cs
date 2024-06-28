using DAL;
using Model;

namespace Service
{
    public class BelastingService
    {
        private const double belastingFactorNormaal = 0.06;
        private const double belastingFactorAlcohol = 0.21;
        public static double[] BerekenBelasting(Bestelling bestelling, bool alcoholisch)
        {
            double[] belastingArray = new double[2];

        }
    }
}