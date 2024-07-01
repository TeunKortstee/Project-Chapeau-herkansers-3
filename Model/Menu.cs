﻿namespace Model
{
    public class Menu
    {
        private List<MenuItem> menuItems;
        private MenuType menuType;

        public List<MenuItem> MenuItems { get { return menuItems; } }
        public MenuType MenuType { get { return menuType; } set { menuType = value; } }

        public Menu()
        {
            menuItems = new List<MenuItem>();
            menuType = MenuType.Lunch;
        }
    }
}
