namespace Model
{
    public class Rekening
    {
        public int Id { get; set; }
        public Bestelling Bestelling { get; set; }
        public float TotaalPrijs { get; set; }
    }
}
