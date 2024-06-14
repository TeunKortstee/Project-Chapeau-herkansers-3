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
        public Rekening? GetRekening(int tafelID)
        {
            string query = "SELECT RekeningId, TafelId, Belasting, TotaalPrijs, Datum, Betaald FROM Rekeningen WHERE TafelID = @tafelId AND Betaald = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tafelId", tafelID),
             
            };
            List<Rekening> rekeningen = ReadTables(ExecuteSelectQuery(query, sqlParameters));
            if (rekeningen.Count > 0) {
                return rekeningen[0];
            }

            // Als er geen rekening gevonden kan worden
            return null;
            
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

                Rekening rekening = new Rekening(Convert.ToInt32(row["RekeningId"]), 
                    Convert.ToInt32(row["TafelId"]), 
                    (double)row["TotaalPrijs"],
                    (bool)row["Betaald"], 
                    (DateTime)row["Datum"],
                    (double)row["Belasting"]);
                
                rekeningen.Add(rekening);
            }
            return rekeningen;
        }

        public int InsertRekening(Rekening rekening)
        {
            string query = "INSERT INTO Rekeningen (TafelId,TotaalPrijs,Betaald,Belasting) VALUES (@TafelId,@TotaalPrijs,@Betaald,@Belasting) SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TafelId", rekening.TafelId),
                new SqlParameter("@TotaalPrijs", rekening.TotaalPrijs),                
                new SqlParameter("@Betaald", rekening.Betaald),
                new SqlParameter("@Belasting", rekening.Belasting)

            };
            return ExecuteEditQueryReturnID(query, sqlParameters);
        }


    }
}
