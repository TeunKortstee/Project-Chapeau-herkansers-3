namespace Model
{
    public class Betaling
    {
        public int BetalingId { get; set; }
        public BetaalMethode Methode { get; set; }
        public double Bedrag { get; set; }
        public Rekening? Rekening { get; set; }
        public double Fooi { get; set; }
        public Betaling(int _BetalingId, int _Methode, double _Bedrag, double _Fooi) {
            BetalingId = _BetalingId;
            Methode = (BetaalMethode)_Methode;
            Bedrag = _Bedrag;
            Fooi = _Fooi;
        }
        public Betaling(int _BetalingId, int _Methode, double _Bedrag, double _Fooi, Rekening _Rekening)
        {
            BetalingId = _BetalingId;
            Methode = (BetaalMethode)_Methode;
            Bedrag = _Bedrag;
            Fooi = _Fooi;
            Rekening = _Rekening;
        }
    }
}
