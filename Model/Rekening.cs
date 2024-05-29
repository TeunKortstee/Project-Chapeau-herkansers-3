namespace Model
{
    public class Rekening
    {
        public int RekeningId { get; set; }
        public int BestellingId { get; set; }
        public float TotaalPrijs { get; set; }
        public float Fooi { get; set; }

        public bool Betaald { get; set; }
    }
}
