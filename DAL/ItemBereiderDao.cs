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
        public List<BesteldeItem> GetAllItems(int personeelsId)
        {
            string query = @"SELECT BesteldItemId, Opmerking, Instuurtijd,  BesteldeItems.MenuItemId, MenuItems.Naam, BesteldeItems.BestellingsId, Hoeveelheid, 
                            Bestellingen.PersoneelsId,  BesteldeItems.GerechtsStatus FROM BesteldeItems JOIN MenuItems ON (MenuItems.MenuItemId=BesteldeItems.MenuItemId) 
                            INNER JOIN Bestellingen ON Bestellingen.BestellingsId = BesteldeItems.BesteldItemId FULL OUTER JOIN Keuken on Keuken.BestellingId = Bestellingen.BestellingsId 
                            WHERE Bestellingen.PersoneelsId = @personeelsId;";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@personeelsId", personeelsId),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    status = (GerechtsStatus)row["GerechtsStatus"]

                };
                items.Add(item);
            }
            return items;
        }

        public void UpdateStatus(GerechtsStatus status, int besteldeItemId)
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
