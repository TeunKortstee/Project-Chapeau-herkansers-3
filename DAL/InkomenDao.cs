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
    public class InkomenDao : BaseDao
    {
        private List<Inkomen> ReadTables(DataTable dataTable)
        {
            List<Inkomen> inkomen = new List<Inkomen>();
            foreach (DataRow row in dataTable.Rows)
            {
                inkomen.Add(MenuItemForInkomen(row));
            }
            return inkomen;
        }
        private Inkomen MenuItemForInkomen(DataRow row)
        {
            MenuItem menuItem = new MenuItem()
            {
                MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                Naam = row["Naam"].ToString(),
            }; 
            Inkomen inkomst = new Inkomen()
            {
                InkomenId = Convert.ToInt32(row["InkomenId"]),
                TotaleInkomen = (double)row["TotaleInkomen"],
                MenuItem = menuItem,
                Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
            };
            return inkomst;
        }
        public void InsertInkomen(MenuItem menuItem, BereidingsPlek bereidingsPlek)
        {
            string query = "INSERT INTO Inkomen (MenuItemId, BereidingsPlek) VALUES (@MenuItemId, @BereidingsPlek)";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@MenuItemId", menuItem.MenuItemId),
                new SqlParameter("@BereidingsPlek", (int)bereidingsPlek),
                };
            ExecuteEditQuery(query, sqlParameters);
        }
        // Lucas
        public List<Inkomen> GetInkomens(bool betaald, BereidingsPlek bereidingsPlek)
        {
            string query = "SELECT i.InkomenId, i.TotaleInkomen, mi.MenuItemId, mi.Naam, i.Hoeveelheid FROM Inkomen i JOIN MenuItems mi ON i.MenuItemId = mi.MenuItemId JOIN BesteldeItems bi ON mi.MenuItemId = bi.MenuItemId JOIN Bestellingen b ON bi.BestellingsId = b.BestellingsId WHERE b.Betaald = @Betaald AND i.BereidingsPlek = @BereidingsPlek";

            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@Betaald", betaald),
                new SqlParameter("@BereidingsPlek", (int)bereidingsPlek),
                };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateInkomen(double totaleInkomen, int hoeveelheid, MenuItem MenuItem)
        {
            string query = "UPDATE Inkomen SET TotaleInkomen = TotaleInkomen + @TotaleInkomen, Hoeveelheid = Hoeveelheid + @Hoeveelheid WHERE MenuItemId = @MenuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@TotaleInkomen", totaleInkomen),
                new SqlParameter("@Hoeveelheid", hoeveelheid),
                new SqlParameter("@MenuItemId", MenuItem.MenuItemId),
                };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
