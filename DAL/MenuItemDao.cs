using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MenuItemDao : BaseDao
    {
        public Menu GetAllItems()
        {
            string query = "SELECT MenuItems.MenuItemId, MenuItems.Naam, " +
                "MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.Voorraad, " +
                "MenuItems.MenuId FROM MenuItems WHERE IsBeschikbaar = 1";   
            return ReadTables(ExecuteSelectQuery(query));
        }

        private Menu ReadTables(DataTable dataTable)
        {
            Menu menu = new Menu();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem menuItem = CreateMenuItemFromRow(row);
                menu.MenuItems.Add(menuItem);
            }
            return menu;
        }

        private MenuItem CreateMenuItemFromRow(DataRow row) //Luciano
        {
            return new MenuItem()
            {
                MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                Voorraad = Convert.ToInt32(row["Voorraad"]),
                Prijs = (double)row["Prijs"],
                Naam = (string)row["Naam"],
                MenuType = (MenuType)Convert.ToInt32(row["MenuId"]),
                IsAlcoholisch = (bool)row["Alcoholisch"],
            };
        }
        // Lucas
        public List<MenuItem> GetMenuItems()
        {
            string query = "SELECT * FROM MenuItems WHERE IsBeschikbaar = 1";
            return ReadTablesWithList(ExecuteSelectQuery(query));
        }
        private List<MenuItem> ReadTablesWithList(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemId = Convert.ToInt32(dr["MenuItemId"]),
                    Voorraad = Convert.ToInt32(dr["Voorraad"]),
                    Prijs = (double)dr["Prijs"],
                    Naam = (string)dr["Naam"],
                    MenuType = (MenuType)Convert.ToInt32(dr["MenuId"]),
                    IsAlcoholisch = (bool)dr["Alcoholisch"],
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        private int ReadTablesWithCount(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                // Get the first row and extract the "AantalVerkocht" value (the count)
                return Convert.ToInt32(dataTable.Rows[0]["TotaalVerkocht"]);
            }
            return 0;
        }
        public void AddNewMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems (Naam, Prijs, Alcoholisch, MenuId) " +
                "VALUES (@Naam, @Prijs, @Alcoholisch, @MenuId);" +
                "SELECT SCOPE_IDENTITY();";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Naam", menuItem.Naam),
                new SqlParameter("@Prijs", menuItem.Prijs),
                new SqlParameter("@Alcoholisch", menuItem.IsAlcoholisch),
                new SqlParameter("@MenuId", (int)menuItem.MenuType),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateMenuItem(MenuItem selectedMenuItem)
        {
            string query = "UPDATE MenuItems SET Naam = @Naam, Prijs = @Prijs, MenuId = @MenuId WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MenuItemId", selectedMenuItem.MenuItemId),
                new SqlParameter("@Naam", selectedMenuItem.Naam),
                new SqlParameter("@Prijs", selectedMenuItem.Prijs),
                new SqlParameter("@MenuId", (int)selectedMenuItem.MenuType),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void UpdateMenuItemStock(MenuItem selectedMenuItem)
        {
            string query = "UPDATE MenuItems SET Voorraad = @Voorraad WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MenuItemId", selectedMenuItem.MenuItemId),
                new SqlParameter("@Voorraad", selectedMenuItem.Voorraad)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            string query = "UPDATE MenuItems SET Voorraad = @Voorraad WHERE MenuItemId = @MenuItemId";
            foreach (BesteldeItem besteldeItem in bestelling.BesteldeItems)
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@MenuItemId", besteldeItem.menuItem.MenuItemId),
                new SqlParameter("@Voorraad", besteldeItem.menuItem.Voorraad)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        public void SoftDeleteMenuItem(MenuItem selectedMenuItem)
        {
            string query = "UPDATE MenuItems SET IsBeschikbaar = 0 WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MenuItemId", selectedMenuItem.MenuItemId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public int GetMenuItemSales(MenuItem menuItem, DateTime datum)
        {
            string query = "SELECT COUNT(*) AS TotaalVerkocht FROM MenuItems mi JOIN BesteldeItems bi ON mi.MenuItemId = bi.MenuItemId JOIN Bestellingen b ON bi.BestellingsId = b.BestellingsId JOIN Rekeningen r ON b.TableNr = r.TafelID WHERE mi.MenuItemId = @MenuItemId AND b.Betaald = 1 AND r.Datum BETWEEN @Datum AND CAST(GETDATE() AS DATE)";

            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@MenuItemId", menuItem.MenuItemId),
                new SqlParameter("@Datum", datum),
                };
            return ReadTablesWithCount(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
