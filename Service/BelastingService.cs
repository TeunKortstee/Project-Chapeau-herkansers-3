using DAL;
using Model;

namespace Service
{
    public class BelastingService
    {
        private const double belastingFactorNormaal = 0.06;
        private const double belastingFactorAlcohol = 0.21;
        public double[] BerekenBelasting(Bestelling bestelling)
        {
            double normaalBelasting = 0.00;
            double alcoholBelasting = 0.00;
            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems) {
                double totaalPrijs = besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid;
                if (besteldeItem.menuItem.IsAlcoholisch)
                {
                    alcoholBelasting += totaalPrijs * belastingFactorAlcohol;
                }
                else {
                    normaalBelasting += totaalPrijs * belastingFactorNormaal;
                }               
            }
            return new double[2] {normaalBelasting, alcoholBelasting};
        }
    }
}