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
    }
}
