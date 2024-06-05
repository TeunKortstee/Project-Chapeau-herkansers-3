namespace Model
{
    public class BesteldeItem
    {
        public int Id { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }

        public int BestellingsID { get; set; }
        public int Hoeveelheid { get; set; }
    }
}
