namespace Model
{
    public class Betaling
    {
        public int BetalingId { get; set; }
        public int Methode { get; set; }
        public double Bedrag { get; set; }
        public int RekeningId { get; set; }

        public double Fooi { get; set; }


        public Betaling(int _BetalingId, int _Methode, double _Bedrag, int _RekeningId, double _Fooi) {
            BetalingId = _BetalingId;
            Methode = _Methode;
            Bedrag = _Bedrag;
            RekeningId = _RekeningId;
            Fooi = _Fooi;
          
        
        }
    }
}
