namespace Model
{
    public class Rekening
    {
        public int RekeningId { get; set; }
        public int BestellingId { get; set; }
        public double TotaalPrijs { get; set; }
        public double Fooi { get; set; }

        public bool Betaald { get; set; }

        public DateTime Datum { get; set; }

        public Rekening(int _RekeningId, int _BestellingId, double _TotaalPrijs, double _Fooi, bool _Betaald, DateTime _Datum) { 
            RekeningId = _RekeningId;
            BestellingId = _BestellingId;
            TotaalPrijs = _TotaalPrijs;
            Fooi = _Fooi;
            Betaald = _Betaald;
            Datum = _Datum;
        
        }
    }
}
