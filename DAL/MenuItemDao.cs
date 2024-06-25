﻿using Model;
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

        private MenuItem CreateMenuItemFromRow(DataRow row) //Luciano
        {
            return new MenuItem()
            {
                MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                Voorraad = Convert.ToInt32(row["Voorraad"]),
                Prijs = (double)row["Prijs"],
                Naam = (string)row["Naam"],
                menuType = (MenuType)Convert.ToInt32(row["MenuId"]),
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
        public List<MenuItem> GetMenuItemsByMenuId(MenuType menu)
        {
            string query = "SELECT mi.* FROM MenuItems mi JOIN Menu m ON mi.MenuId = m.MenuId WHERE mi.MenuId = @MenuId AND Beschikbaar = 1";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@MenuId", (int)menu),
                };
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
                    Prijs = (double)dr["Prijs"],
                    Naam = (string)dr["Naam"],
                    menuType = (MenuType)Convert.ToInt32(dr["MenuId"]),
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
                new SqlParameter("@MenuId", menuItem.menuType),
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

        public void UpdateAllMenuItemsStock(Bestelling bestelling)
        {
            string query = "UPDATE MenuItems SET Voorraad = @Voorraad WHERE MenuItemId = @MenuItemId";
            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
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
            string query = "UPDATE MenuItems SET Beschikbaar = 0 WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MenuItemId", selectedMenuItem.MenuItemId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
