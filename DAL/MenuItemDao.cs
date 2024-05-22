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
    public class MenuItemDao : BaseDao
    {
        //public MenuItem GetById(int id)
        //{
        //    string query =
        //        "SELECT MenuItemId, MenuItem.Naam, MenuItem.Alcoholisch, MenuItem.MenuType" +
        //        "Menu.id , Menu.[name] FROM MenuItem" +
        //        "JOIN Menu ON MenuItem.Menu_id = Menu.id " +
        //        "WHERE MenuItem.id = @id";
        //    SqlParameter[] sqlParameters = new SqlParameter[]
        //    {
        //        new SqlParameter("@id", id),
        //    };
        //    return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        //}

        //private MenuItem ReadSingle(DataTable dataTable)
        //{
        //    DataRow row = dataTable.Rows[0];
        //    if (dataTable.Rows.Count > 0)
        //    {
        //        return CreateMenuItemFromRow(row);
        //    };
        //    return null;
        //}
    }
}
