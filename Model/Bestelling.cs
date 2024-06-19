namespace Model
{
    public class Bestelling
    {
        private List<BesteldeItem> besteldeItems;
        public int bestellingId { get; set; }
        public List<BesteldeItem> BestellingItems { get; set; }
        //public Personeel personeel { get; set; }

        public bool betaald { get; set; }

        public Tafel tafel { get; set; }
        public GerechtsStatus status { get; set; }

        public Bestelling(Tafel tafel) //Luciano
        {
            this.tafel = tafel;
            BestellingItems = new List<BesteldeItem>();
            betaald = false;
        }

        public Bestelling() //Yusuf
        {

        }

        public Bestelling(int _bestellingId, Personeel _personeel, bool _betaald, int _tafelId) //Laurens
        {
            besteldeItems = new List<BesteldeItem>();
            bestellingId = _bestellingId;
            //personeel = _personeel;
            betaald = _betaald;
            //tafelId = _tafelId;
        }

    }
}
