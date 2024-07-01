using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BetalingDao : BaseDao
    {
        public Betaling GetBetaling(Rekening rekening)
        {
            string query = "SELECT BetalingID, Methode, Bedrag, RekeningID, Fooi FROM Betalingen WHERE RekeningID = @rekeningId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@rekeningId", rekening.RekeningId),
             
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters),rekening)[0];
        }
        private List<Betaling> ReadTables(DataTable dataTable,Rekening rekening)
        {
            List<Betaling> betalingen = new List<Betaling>();
            foreach (DataRow row in dataTable.Rows)
            {
                    Betaling betaling = new Betaling(Convert.ToInt32(row["BetalingId"]),
                    Convert.ToInt32(row["Methode"]),
                    (double)row["Bedrag"],
                    (double)row["Fooi"],
                    rekening);

                betalingen.Add(betaling);
            }
            return betalingen;
        }
        public void InsertBetalingen(List<Betaling> betalingen)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Methode",typeof(int));
            table.Columns.Add("Bedrag", typeof(double));
            table.Columns.Add("RekeningID", typeof(int));
            table.Columns.Add("Fooi", typeof(double));

            foreach (Betaling betaling in betalingen) {
                table.Rows.Add((int)betaling.Methode,betaling.Bedrag,betaling.Rekening.RekeningId,betaling.Fooi);            
            }            
            try
            {
                SqlConnection connection = OpenConnection();
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connection)) {
                    sqlBulkCopy.DestinationTableName = "Betalingen";
                    sqlBulkCopy.WriteToServer(table);
                }                
            }
            catch (SqlException e)
            {
                Debug.Fail(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        // Lucas
        public List<Betaling> GetBetalingen(bool betaald)
        {
            string query = "SELECT b.* FROM Betalingen b JOIN Rekeningen r ON b.RekeningID = r.RekeningID WHERE r.Betaald = @betaald";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@betaald", betaald),

            };
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
