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
        //public MenuItem GetById(int id)
        //{
        //    string query =
        //        "SELECT MenuItemId, MenuItem.Naam, MenuItem.Alcoholisch, MenuItem.MenuType" +
        //        "Menu.id , Menu.[name] FROM MenuItem" +
        //        "JOIN Menu ON MenuItem.Menu_id = Menu.id " +
        //        "WHERE MenuItem.id = @id";
        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@id", id),
        //    };
        //    return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        //}

        //private MenuItem ReadSingle(DataTable dataTable)
        //{
        //    DataRow row = dataTable.Rows[0];
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        return CreateMenuItemFromRow(row);
        //    };
        //    return null;
        //}

        public List<MenuItem> GetAllItems()
        {
            string query = "SELECT Menu.MenuId, Menu.MenuType, MenuItems.MenuItemId, MenuItems.Naam, " +
                "MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.MenuId AS MenuItem_MenuId, " +
                "MenuItems.Voorraad FROM Menu JOIN MenuItems ON Menu.MenuId = MenuItems.MenuId;";   
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem menuItem = CreateMenuItemFromRow(row);
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        private MenuItem CreateMenuItemFromRow(DataRow row)
        {
            Menu menu = new Menu()
            {
                menuId = (int)row["Menu.Id"],
            };
            return new MenuItem()
            {
                MenuItemId = (int)row["MenuItem_Id"],
                menu = menu,
                Voorraad = (int)row["MenuItems.Voorraad"],
                Prijs = (float)row["MenuItems.Prijs"],
                Naam = (string)row["MenuItems.Naam"],
                IsAlcoholisch = (bool)row["MenuItems.Alcoholisch"],
            };
        }
    }
}
