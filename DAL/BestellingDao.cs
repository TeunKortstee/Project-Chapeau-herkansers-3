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
            string query = "SELECT BestellingId, PersoneelsId, TableNr, Betaald FROM Bestellingen WHERE TableNr = @tafelId AND Betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tafelId", tafelID),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bestelling> ReadTables(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
           
            foreach (DataRow row in dataTable.Rows)
            {
                Personeel personeel = new Personeel();
                personeel.Id = Convert.ToInt32(row["PersoneelId"]);
                Bestelling bestelling = new Bestelling(Convert.ToInt32(row["BestellingId"]),
                    personeel,
                    (bool)row["Betaald"],
                    Convert.ToInt32(row["TableNr"]));

                bestellingen.Add(bestelling);
            }
            return bestellingen;
        }



    }
}
