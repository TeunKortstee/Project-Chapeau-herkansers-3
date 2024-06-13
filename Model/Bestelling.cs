namespace Model
{
    public class Bestelling
    {
        public int Id { get; set; }
        public List<BesteldeItem> Items { get; set; }
        public Personeel personeel { get; set; }

        public int TafelId { get; set; }
    }
}
