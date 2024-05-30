namespace Model
{
    public class Bestelling
    {
        private List<BesteldItem> besteldItems;
        public int bestellingId { get; set; }
        public List<BesteldItem> BestellingItems { get { return besteldItems; } set { besteldItems = value; } }
        public Personeel personeel { get; set; }

        public Bestelling()
        {
            besteldItems = new List<BesteldItem>();
        }
    }
}
