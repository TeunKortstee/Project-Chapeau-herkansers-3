namespace Model
{
    public class BesteldItem
    {
        public int Id { get; set; }
        public string Opmerking { get; set; }
        public DateTime InstuurTijd { get; set; }
        public MenuItem menuItem { get; set; }

        public int Hoeveelheid { get; set; }
    }
}
