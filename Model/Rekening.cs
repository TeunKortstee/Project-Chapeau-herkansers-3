using System.Runtime.InteropServices;

namespace Model
{
    public class Rekening
    {
        public int RekeningId { get; set; }
        public Tafel Tafel { get; set; }
        public double TotaalPrijs { get; set; }
        public double BelastingNormaal { get; set; }
        public double BelastingAlcoholisch { get; set; }     
        public DateTime Datum { get; set; }
        public string Opmerkingen { get; set; }
        public List<Bestelling> Bestellingen { get; set; }
        public List<Betaling> Betalingen { get; set; }
        public Rekening(int _RekeningId, Tafel _Tafel, double _TotaalPrijs, DateTime _Datum, double _BelastingNormaal, double _BelastingAlcoholisch, string _Opmerkingen) {
            Bestellingen = new List<Bestelling>();
            Betalingen = new List<Betaling>();
            RekeningId = _RekeningId;
            Tafel = _Tafel;
            TotaalPrijs = _TotaalPrijs;           
            Datum = _Datum;
            BelastingNormaal = _BelastingNormaal;
            BelastingAlcoholisch = _BelastingAlcoholisch;
            Opmerkingen = _Opmerkingen;
        }
        public Rekening(List<Bestelling> _Bestellingen, Tafel _Tafel, double _TotaalPrijs, double _BelastingNormaal, double _BelastingAlcoholisch)
        {
            Bestellingen = _Bestellingen;
            RekeningId = 0;
            Tafel = _Tafel;
            TotaalPrijs = _TotaalPrijs;
            BelastingNormaal = _BelastingNormaal;
            BelastingAlcoholisch = _BelastingAlcoholisch;
            Datum = DateTime.Now;
            Opmerkingen = "";
            Betalingen = new List<Betaling>();
        }

    }
}