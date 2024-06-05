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
    public class BesteldeItemDao : BaseDao
    {
        public List<BesteldeItem> GetItemsFromBestelling(int bestellingID)
        {
            string query = "SELECT BesteldeItems.BesteldItemId, BesteldeItems.Opmerking, BesteldeItems.Instuurtijd, BesteldeItems.BestellingsId, BesteldeItems.Hoeveelheid, MenuItems.MenuItemId, MenuItems.Naam, MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.MenuId, MenuItems.Voorraad FROM BesteldeItems JOIN MenuItems ON MenuItems.MenuItemId=BesteldeItems.MenuItemId WHERE BestellingsId = @bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@bestellingId", bestellingID),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<BesteldeItem> ReadTables(DataTable dataTable)
        {
            List<BesteldeItem> items = new List<BesteldeItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem _menuItem = new MenuItem()
                {
                    MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                    Voorraad = Convert.ToInt32(row["Voorraad"]),
                    Prijs = (double)row["Prijs"],
                    Naam = (string)row["Naam"],
                    MenuId = Convert.ToInt32(row["MenuId"]),
                    IsAlcoholisch = (bool)row["Alcoholisch"]

                };

                BesteldeItem item = new BesteldeItem()
                {
                    Id = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["Instuurtijd"],
                    menuItem = _menuItem,               
                    BestellingsID = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"])
                };
                items.Add(item);
            }
            return items;
        }

       
    }
}
