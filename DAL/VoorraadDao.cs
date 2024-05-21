using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VoorraadDao : BaseDao
    {
        public List<Voorraad> GetAllVoorraden()
        {
            string query = "SELECT StudentId, Name FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Voorraad> ReadTables(DataTable dataTable)
        {
            List<Voorraad> voorraden = new List<Voorraad>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Voorraad voorraad = new Voorraad()
                {
                    VoorraadId = (int)dr["VoorraadId"],
                    InVoorraad = (int)dr["InVoorraad"],
                    MenuItemId = (int)dr["MenuItemId"]
                };
                voorraden.Add(voorraad);
            }
            return voorraden;
        }
    }
}
