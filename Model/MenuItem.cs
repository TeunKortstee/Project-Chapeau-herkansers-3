﻿namespace Model
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Naam { get; set; }
        public double Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public MenuType menuType { get; set; }
        public int Voorraad { get; set; }
        public GerechtsType GerechtsType { get; set; }
        public MenuItem()
        {

        }

        public MenuItem(string naam, double prijs, bool isAlcoholisch, MenuType menuId, int voorraad)
        {
            Naam = naam;
            Prijs = prijs;
            IsAlcoholisch = isAlcoholisch;
            menuType = menuId;
            Voorraad = voorraad;
        }
    }
}
