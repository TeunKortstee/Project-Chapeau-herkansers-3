using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDao : BaseDao
    {
        public Menu GetMenu()
        {
            string query = "SELECT * FROM Menu WHERE"; ;
            SqlParameter[] sqlParameters = new SqlParameter[]
{
                new SqlParameter("@Voornaam", personeel.Voornaam),
                new SqlParameter("@Wachtwoord", personeel.Wachtwoord)
};
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
