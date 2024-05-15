namespace Model
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public Menu menu { get; set; }
        public GerechtsType GerechtsType { get; set; }
    }
}
