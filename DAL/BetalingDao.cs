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
        private List<Betaling> ReadTables(DataTable dataTable)
        {
            List<Betaling> betalingen = new List<Betaling>();
            foreach (DataRow row in dataTable.Rows)
            {
                    Betaling betaling = new Betaling(Convert.ToInt32(row["BetalingId"]),
                    Convert.ToInt32(row["Methode"]),
                    (double)row["Bedrag"],
                    (double)row["Fooi"]);

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
                table.Rows.Add((int)betaling.Methode, betaling.Bedrag,betaling.Rekening.RekeningId,betaling.Fooi);            
            }            
            try
            {
                SqlConnection connection = OpenConnection();
                using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connection)) {
                    foreach (DataColumn column in table.Columns)
                    {
                        sqlBulkCopy.ColumnMappings.Add(column.ColumnName,column.ColumnName);
                    }
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

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
