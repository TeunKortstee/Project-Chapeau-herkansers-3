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
    public class RekeningDao : BaseDao
    {
        public Rekening GetRekening(int bestellingID)
        {
            string query = "SELECT RekeningId, BestellingId, TotaalPrijs, Fooi, Betaald FROM Rekeningen WHERE BestellingId = @bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@bestellingId", bestellingID),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        // Lucas
        public List<Rekening> GetBetaaldeRekeningen(bool betaald)
        {
            string query = "SELECT * FROM Rekeningen WHERE Betaald = @Betaald";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Betaald", betaald),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Rekening> ReadTables(DataTable dataTable)
        {
            List<Rekening> rekeningen = new List<Rekening>();
            foreach (DataRow row in dataTable.Rows)
            {

                Rekening rekening = new Rekening()
                {
                    RekeningId = Convert.ToInt32(row["RekeningId"]),
                    BestellingId = Convert.ToInt32(row["BestellingId"]),
                    TotaalPrijs = (float)row["TotaalPrijs"],
                    Fooi = (float)row["Fooi"],                    
                    Betaald = (bool)row["Betaald"]
                };
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }

       
    }
}
