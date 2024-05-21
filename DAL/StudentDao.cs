using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class StudentDao : BaseDao
    {
        public List<Personeel> GetAllStudents()
        {
            string query = "SELECT StudentId, Name FROM [TABLE]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Personeel> ReadTables(DataTable dataTable)
        {
            List<Personeel> students = new List<Personeel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Personeel student = new Personeel()
                {
                    Number = (int)dr["StudentId"],
                    Name = dr["Name"].ToString()
                };
                students.Add(student);
            }
            return students;
        }
    }
}
