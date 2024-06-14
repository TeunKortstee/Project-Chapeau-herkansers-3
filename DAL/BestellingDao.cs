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
    public class BestellingDao : BaseDao
    {
        public List<Bestelling> GetBestellingen(int tafelID)
        {
            string query = "SELECT BestellingsId, PersoneelsId, TableNr, Betaald FROM Bestellingen WHERE TableNr = @tafelId AND Betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tafelId", tafelID),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }



        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            BesteldeItemDao besteldeItemDao = new BesteldeItemDao();
           
            foreach (DataRow row in dataTable.Rows)
            {
               
               
                Bestelling bestelling = new Bestelling(Convert.ToInt32(row["BestellingsId"]),
                     new Personeel(),
                    (bool)row["Betaald"],
                    Convert.ToInt32(row["TableNr"]));

                bestelling.BestellingItems = besteldeItemDao.GetItemsFromBestelling(bestelling.bestellingId);

                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }



    }
}
