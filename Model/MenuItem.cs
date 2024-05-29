namespace Model
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public Menu menu { get; set; }
        public int Voorraad { get; set; }
        public GerechtsType GerechtsType { get; set; }
    }
}
