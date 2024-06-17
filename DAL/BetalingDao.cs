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
                    Convert.ToInt32(row["Methode"]),
                    (double)row["Bedrag"],
                    Convert.ToInt32(row["RekeningId"]),
                    (double)row["Fooi"]);

                betalingen.Add(betaling);
            }
            return betalingen;
        }

        public void InsertBetaling(Betaling betaling)
        {
            string query = "INSERT INTO Betalingen(Methode,Bedrag,RekeningID,Fooi) VALUES (@Methode,@Bedrag,@RekeningID,@Fooi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Methode", (int)betaling.Methode),
                new SqlParameter("@Bedrag", betaling.Bedrag),
                new SqlParameter("@RekeningID", betaling.RekeningId),
                new SqlParameter("@Fooi", betaling.Fooi)

            };
            ExecuteEditQuery(query, sqlParameters);
        }
        // Lucas
        public List<Betaling> GetBetalingen(bool betaald)
        {
            string query = "SELECT b.* FROM Betalingen b JOIN Rekeningen r ON b.RekeningID = r.RekeningID WHERE r.Betaald = @betaald";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@betaald", betaald),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }



    }
}
