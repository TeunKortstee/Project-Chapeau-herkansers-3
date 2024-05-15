namespace Model
{
    public class Bestelling
    {
        public int Id { get; set; }
        public List<BesteldItem> Items { get; set; }
        public Personeel personeel { get; set; }
    }
}
