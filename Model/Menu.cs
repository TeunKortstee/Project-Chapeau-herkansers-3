namespace Model
{
    public class Menu
    {
        public int MenuId { get;}
        private List<MenuItem> menuItems;
        private MenuType menuType;

        public List<MenuItem> MenuItems { get { return menuItems; } set { menuItems = value; } }
        public MenuType MenuType { get { return menuType; } set { menuType = value; } }
    }
}
