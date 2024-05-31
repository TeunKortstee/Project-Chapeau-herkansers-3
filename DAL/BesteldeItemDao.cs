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
            string query = "SELECT BesteldItemId, Opmerking, Instuurtijd, MenuItemId, BestellingId, Hoeveelheid FROM BesteldeItems WHERE BestellingsId = @bestellingId";
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

                BesteldeItem item = new BesteldeItem()
                {
                    Id = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["InstuurTijd"],
                    MenuItemID = Convert.ToInt32(row["MenuItemID"]),                    
                    BestellingsID = Convert.ToInt32(row["Betaald"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"])
                };
                items.Add(item);
            }
            return items;
        }

       
    }
}
