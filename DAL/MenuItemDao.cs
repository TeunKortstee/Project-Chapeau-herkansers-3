using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuItemDao : BaseDao
    {
        public Menu GetAllItems()
        {
            string query = "SELECT MenuItems.MenuItemId, MenuItems.Naam, " +
                "MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.Voorraad, " +
                "MenuItems.MenuId FROM MenuItems";   
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

        private MenuItem CreateMenuItemFromRow(DataRow row)
        {
            return new MenuItem()
            {
                MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                Voorraad = Convert.ToInt32(row["Voorraad"]),
                Prijs = (decimal)row["Prijs"],
                Naam = (string)row["Naam"],
                MenuId = Convert.ToInt32(row["MenuId"]),
                IsAlcoholisch = (bool)row["Alcoholisch"],
            };
        }
        // Lucas
        public List<MenuItem> GetAllMenuItems()
        {
            string query = "SELECT * FROM MenuItems";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTablesWithList(ExecuteSelectQuery(query, sqlParameters));
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
                    Prijs = (decimal)dr["Prijs"],
                    Naam = (string)dr["Naam"],
                    MenuId = Convert.ToInt32(dr["MenuId"]),
                    IsAlcoholisch = (bool)dr["Alcoholisch"],
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        public void AddNewMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO MenuItems (Naam, Prijs, Alcoholisch, MenuId, Voorraad) VALUES (@Naam, @Prijs, @Alcoholisch, @MenuId, @Voorraad)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Naam", menuItem.Naam),
                new SqlParameter("@Prijs", menuItem.Prijs),
                new SqlParameter("@Alcoholisch", menuItem.IsAlcoholisch),
                new SqlParameter("@MenuId", menuItem.MenuId),
                new SqlParameter("@Voorraad", menuItem.Voorraad)
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
        public void DeleteMenuItem(MenuItem selectedMenuItem)
        {
            string query = "DELETE FROM MenuItems WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MenuItemId", selectedMenuItem.MenuItemId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
