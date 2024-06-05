using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class BesteldeItemDao : BaseDao
    {
        //public List<BesteldItem> GetItemsFromBestelling(int bestellingID)
        //{
        //    string query = "SELECT BesteldItemId, Opmerking, Instuurtijd, MenuItemId, BestellingsId, Hoeveelheid FROM BesteldeItems WHERE BestellingsId = @bestellingId";
        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@bestellingId", bestellingID),

        //    };
        //    return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        //}

        public Bestelling BestellingAanmaken(Bestelling bestelling, Personeel personeel)
        {
            string query = "INSERT INTO Bestellingen (Personeelsid) VALUES (0); SELECT @@IDENTITY AS BestellingsId;";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@PersoneelsId", personeel.Id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), bestelling);
        }

        private Bestelling ReadTables(DataTable dataTable, Bestelling bestelling)
        {
            bestelling.bestellingId = Convert.ToInt32(dataTable.Rows[0]["BestellingsId"]);
            return bestelling;
        }

        public void BestellingItemsAanmaken(Bestelling bestelling)
        {
            string query = "INSERT INTO BesteldeItems (Opmerking, Instuurtijd, MenuItemId, BestellingsId, Hoeveelheid) " +
                "VALUES (@Opmerking, @InstuurTijd, @MenuItemId, @BestellingsId, @Hoeveelheid)";

            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Opmerking", besteldeItem.Opmerking),
                    new SqlParameter("@InstuurTijd", besteldeItem.InstuurTijd),
                    new SqlParameter("@MenuItemId", besteldeItem.menuItem.MenuItemId),
                    new SqlParameter("@BestellingsId", bestelling.bestellingId),
                    new SqlParameter("@Hoeveelheid", besteldeItem.Hoeveelheid)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}
