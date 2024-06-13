namespace Model
{
    public class BesteldeItem
    {
        public int Id { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public int MenuItemID { get; set; }

        public int BestellingsID { get; set; }
        public int Hoeveelheid { get; set; }
        public int Count { get; set; }
    }
}
