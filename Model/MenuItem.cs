namespace Model
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public MenuType MenuType { get; set; }
        //public GerechtsType GerechtsType { get; set; }
        public int Voorraad { get; set; }
        public MenuItem()
        {

        }

        public MenuItem(string naam, double prijs, bool isAlcoholisch, MenuType menuId)
        {
            Naam = naam;
            Prijs = prijs;
            IsAlcoholisch = isAlcoholisch;
            MenuType = menuId;
        }
        public int TotaalVerkocht { get; set; }
        public double TotaleInkomen
        { 
            get { return Prijs * TotaalVerkocht; } 
        }
    }
}
