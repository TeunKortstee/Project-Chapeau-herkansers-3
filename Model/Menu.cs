﻿namespace Model
{
    public class Menu
    {
        public int MenuId { get; set; }
        private List<MenuItem> menuItems;
        private MenuType menuType;

        public List<MenuItem> MenuItems { get { return menuItems; } set { menuItems = value; } }
        public MenuType MenuType { get { return menuType; } set { menuType = value; } }

        public Menu()
        {
            MenuId = 1;
            menuItems = new List<MenuItem>();
            menuType = MenuType.Lunch;
        }
    }
}
