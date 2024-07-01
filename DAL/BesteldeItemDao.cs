using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BesteldeItemDao : BaseDao
    {
        public List<BesteldeItem> GetItemsFromBestelling(int bestellingID)
        {
            string query = "SELECT BesteldeItems.BesteldItemId, BesteldeItems.Opmerking, BesteldeItems.Instuurtijd, BesteldeItems.BestellingsId, BesteldeItems.GerechtsStatus, BesteldeItems.Hoeveelheid, MenuItems.MenuItemId, MenuItems.Naam, MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.MenuId, MenuItems.Voorraad FROM BesteldeItems JOIN MenuItems ON MenuItems.MenuItemId=BesteldeItems.MenuItemId WHERE BestellingsId = @bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@bestellingId", bestellingID),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void BestellingEnBesteldeItemsAanmaken(Bestelling bestelling) //verbetering
        {
            string queryToevoegenBestelling = "INSERT INTO Bestellingen (TableNr) VALUES (@TafelNummer); SELECT @@IDENTITY AS BestellingsId;";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@TafelNummer", bestelling.tafel.Id)
            };
            bestelling.bestellingId = Convert.ToInt32(ExecuteSelectQuery(queryToevoegenBestelling, sqlParameters).Rows[0]["BestellingsId"]);

            string queryToevoegenBesteldeItem = "INSERT INTO BesteldeItems (Opmerking, Instuurtijd, MenuItemId, GerechtsStatus, BestellingsId, Hoeveelheid) " +
            "VALUES (@Opmerking, @InstuurTijd, @MenuItemId, @GerechtsStatus, @BestellingsId, @Hoeveelheid)";

            foreach (BesteldeItem besteldeItem in bestelling.BesteldeItems)
            {
                SqlParameter[] sqlParameters2 = new SqlParameter[] {
                    new SqlParameter("@Opmerking", besteldeItem.Opmerking),
                    new SqlParameter("@InstuurTijd", besteldeItem.InstuurTijd),
                    new SqlParameter("@MenuItemId", besteldeItem.menuItem.MenuItemId),
                    new SqlParameter("@BestellingsId", bestelling.bestellingId),
                    new SqlParameter("@Hoeveelheid", besteldeItem.Hoeveelheid),
                    new SqlParameter("@GerechtsStatus", (int)besteldeItem.Status)
                };
                ExecuteEditQuery(queryToevoegenBesteldeItem, sqlParameters2);
            }
        }

        private List<BesteldeItem> ReadTables(DataTable dataTable)
        {
            List<BesteldeItem> items = new List<BesteldeItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem _menuItem = new MenuItem()
                {
                    MenuItemId = Convert.ToInt32(row["MenuItemId"]),
                    Voorraad = Convert.ToInt32(row["Voorraad"]),
                    Prijs = (double)row["Prijs"],
                    Naam = (string)row["Naam"],
                    MenuType = (MenuType)Convert.ToInt32(row["MenuId"]),
                    IsAlcoholisch = (bool)row["Alcoholisch"]

                };
                BesteldeItem item = new BesteldeItem(_menuItem)
                {
                    BesteldItemId = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["Instuurtijd"],
                    //BestellingsID = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
                    Naam = row["Naam"].ToString(),
                    Status = (GerechtsStatus)row["GerechtsStatus"]

                };
                items.Add(item);
            }
            return items;
        }
    }
}
