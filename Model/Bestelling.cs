namespace Model
{
    public class Bestelling
    {
        private List<BesteldeItem> besteldeItems;
        public int bestellingId { get; set; }
        public List<BesteldeItem> BestellingItems { get { return besteldeItems; } set { besteldeItems = value; } }
        public Personeel personeel { get; set; }

        public bool betaald { get; set; }

        public int tafelId { get; set; }
        public GerechtsStatus status { get; set; }

        public Bestelling()
        {
            BestellingItems = new List<BesteldeItem>();
            betaald = false;
        }

        public Bestelling(int _bestellingId, Personeel _personeel, bool _betaald, int _tafelId)
        {
            besteldeItems = new List<BesteldeItem>();
            bestellingId = _bestellingId;
            personeel = _personeel;
            betaald = _betaald;
            tafelId = _tafelId;
        }

    }
}
