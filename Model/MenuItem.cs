namespace Model
{
    public class MenuItem
    {
        public int MenuItemId { get;}
        public string Naam { get; set; }
        public float Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public Menu menu { get; set; }
        public int Voorraad { get; set; }
        public MenuItem()
        {

        }

        public MenuItem(string naam, float prijs, bool isAlcoholisch, Menu menu)
        {
            Naam = naam;
            Prijs = prijs;
            IsAlcoholisch = isAlcoholisch;
            this.menu = menu;
        }
    }
}
