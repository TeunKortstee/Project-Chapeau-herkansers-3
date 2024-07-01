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
    public class ItemBereiderDao : BaseDao
    {
        public List<BesteldeItem> GetAllBesteldeItems()
        {
            string query = @"
            SELECT 
                BesteldItemId, 
                Opmerking, 
                Instuurtijd,  
                BesteldeItems.MenuItemId, 
                MenuItems.Naam, 
                BesteldeItems.BestellingsId, 
                Hoeveelheid, 
                Bestellingen.PersoneelsId,  
                BesteldeItems.GerechtsStatus 
            FROM 
                BesteldeItems 
            JOIN 
                MenuItems ON MenuItems.MenuItemId = BesteldeItems.MenuItemId 
            JOIN 
                Bestellingen ON Bestellingen.BestellingsId = BesteldeItems.BesteldItemId
            WHERE 
                Instuurtijd >= DATEADD(day, -1, GETDATE());
            ";
            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<BesteldeItem> ReadTables(DataTable dataTable)
        {
            List<BesteldeItem> items = new List<BesteldeItem>();
            foreach (DataRow row in dataTable.Rows)
            { 
                BesteldeItem item = new BesteldeItem()
                {
                    BesteldItemId = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["Instuurtijd"],
                    BestellingsID = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
                    Naam = row["Naam"].ToString(),
                    Status = (GerechtsStatus)row["GerechtsStatus"]
                };
                items.Add(item);
            }
            return items;
        }

        public void UpdateBestellingStatus(GerechtsStatus status, int besteldeItemId)
        {
            string query = "UPDATE BesteldeItems SET GerechtsStatus = @status WHERE BesteldItemId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@status", (int)status),
                new SqlParameter("@id", besteldeItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
