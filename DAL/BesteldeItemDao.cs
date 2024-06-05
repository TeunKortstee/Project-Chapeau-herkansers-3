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

        public void BestellingAanmaken(Bestelling bestelling)
        {
            string query = "INSERT INTO BesteldeItems (Opmerking, InstuurTijd, MenuItemId, BestellingsId, Hoeveelheid) " +
                "VALUES (@Opmerking, InstuurTijd, @BestellingsId, @MenuItemId, @Hoeveelheid)";

            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Opmerking", besteldeItem.Opmerking),
                    new SqlParameter("@InstuurTijd", besteldeItem.InstuurTijd),
                    new SqlParameter("@BestellingsId", bestelling.bestellingId),
                    new SqlParameter("@MenuItemId", besteldeItem.menuItem.MenuItemId),
                    new SqlParameter("@Hoeveelheid", besteldeItem.Hoeveelheid)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }
    }
}
