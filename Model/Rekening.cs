using System.Runtime.InteropServices;

namespace Model
{
    public class Rekening
    {
        public int RekeningId { get; set; }
        public int TafelId { get; set; }
        public double TotaalPrijs { get; set; }

        public double Belasting { get; set; }
        public bool Betaald { get; set; }

        public double VAT { get; set; }

        public DateTime Datum { get; set; }

        public string Opmerkingen { get; set; }

        public List<Bestelling> Bestellingen { get; set; }

        

        public Rekening(int _RekeningId, int _TafelId, double _TotaalPrijs, bool _Betaald, DateTime _Datum, double _Belasting, string _Opmerkingen) {
            Bestellingen = new List<Bestelling>();
            
            RekeningId = _RekeningId;
            TafelId = _TafelId;
            TotaalPrijs = _TotaalPrijs;
            
            Betaald = _Betaald;
            Datum = _Datum;
            Belasting = _Belasting;
            Opmerkingen = _Opmerkingen;


        }
    }
}
