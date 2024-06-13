namespace Model
{
    public class Bestelling
    {
        private List<BesteldeItem> besteldeItems;
        public int bestellingId { get; set; }
        public List<BesteldeItem> BestellingItems { get { return besteldeItems; } set { besteldeItems = value; } }
        public Personeel personeel { get; set; }


        public int TafelId { get; set; }

        public Bestelling()
        {
            besteldeItems = new List<BesteldeItem>();
        }

    }
}
