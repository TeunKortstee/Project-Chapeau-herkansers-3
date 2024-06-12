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
    public class BetalingDao : BaseDao
    {
        public Betaling GetBetaling(int rekeningID)
        {
            string query = "SELECT BetalingID, Methode, Bedrag, RekeningID, Fooi FROM Betalingen WHERE RekeningID = @rekeningId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@rekeningId", rekeningID),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Betaling> ReadTables(DataTable dataTable)
        {
            List<Betaling> betalingen = new List<Betaling>();
            foreach (DataRow row in dataTable.Rows)
            {

                Betaling betaling = new Betaling(Convert.ToInt32(row["BetalingId"]),
                    Convert.ToInt32(row["MethodeId"]),
                    (double)row["Bedrag"],
                    Convert.ToInt32(row["RekeningId"]),
                    (double)row["Fooi"]);

                betalingen.Add(betaling);
            }
            return betalingen;
        }

        public void InsertBetaling(Betaling betaling)
        {
            string query = "INSERT INTO Betaling(Methode,Bedrag,RekeningID,Fooi) VALUES (@Methode,@Bedrag,@RekeningID,@Fooi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Methode", betaling.Methode),
                new SqlParameter("@TotaalPrijs", rekening.TotaalPrijs),                
                new SqlParameter("@Betaald", rekening.Betaald),

            };
            ExecuteEditQuery(query, sqlParameters);
        }


    }
}
