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
                IsAlcoholisch = (bool)row["Alcoholisch"],
            };
        }
    }
}
