namespace Model
{
    public class Betaling
    {
        public int BetalingId { get; set; }
        public int Methode { get; set; }
        public double Bedrag { get; set; }
        public int RekeningId { get; set; }

        public Betaling(int _BetalingId, int _Methode, double _Bedrag, int _RekeningId) {
            BetalingId = _BetalingId;
            Methode = _Methode;
            Bedrag = _Bedrag;
            RekeningId = _RekeningId;
          
        
        }
    }
}
