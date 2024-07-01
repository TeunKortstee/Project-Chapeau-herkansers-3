﻿namespace Model
{
    public class Bestelling
    {
        private List<BesteldeItem> besteldeItems; //Yusuf
        public int bestellingId { get; set; }
        public List<BesteldeItem> BesteldeItems { get; set; } //Luciano

        public bool betaald { get; set; }

        public Tafel tafel { get; set; } //Luciano
        public GerechtsStatus status { get; set; } //Yusuf

        public Bestelling(Tafel tafel) //Luciano
        {
            this.tafel = tafel;
            BesteldeItems = new List<BesteldeItem>();
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
