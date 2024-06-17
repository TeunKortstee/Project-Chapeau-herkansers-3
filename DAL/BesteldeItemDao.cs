using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class BesteldeItemDao : BaseDao
    {
        public List<BesteldeItem> GetItemsFromBestelling(int bestellingID)
        {
            string query = "SELECT BesteldeItems.BesteldItemId, BesteldeItems.Opmerking, BesteldeItems.Instuurtijd, BesteldeItems.BestellingsId, BesteldeItems.Hoeveelheid, MenuItems.MenuItemId, MenuItems.Naam, MenuItems.Prijs, MenuItems.Alcoholisch, MenuItems.MenuId, MenuItems.Voorraad FROM BesteldeItems JOIN MenuItems ON MenuItems.MenuItemId=BesteldeItems.MenuItemId WHERE BestellingsId = @bestellingId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@bestellingId", bestellingID),

            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Bestelling BestellingAanmaken(Bestelling bestelling, Personeel personeel, Tafel tafel)
        {
            string query = "INSERT INTO Bestellingen (Personeelsid, TableNr) VALUES (@PersoneelsId, @TafelNummer); SELECT @@IDENTITY AS BestellingsId;";
            SqlParameter[] sqlParameters = new SqlParameter[] {
                new SqlParameter("@PersoneelsId", personeel.Id),
                new SqlParameter("@TafelNummer", tafel.Id)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), bestelling);
        }

        private Bestelling ReadTables(DataTable dataTable, Bestelling bestelling)
        {
            bestelling.bestellingId = Convert.ToInt32(dataTable.Rows[0]["BestellingsId"]);
            return bestelling;
        }

        public void BestellingItemsAanmaken(Bestelling bestelling)
        {
            string query = "INSERT INTO BesteldeItems (Opmerking, Instuurtijd, MenuItemId, BestellingsId, Hoeveelheid) " +
                "VALUES (@Opmerking, @InstuurTijd, @MenuItemId, @BestellingsId, @Hoeveelheid)";

            foreach (BesteldeItem besteldeItem in bestelling.BestellingItems)
            {
                SqlParameter[] sqlParameters = new SqlParameter[] {
                    new SqlParameter("@Opmerking", besteldeItem.Opmerking),
                    new SqlParameter("@InstuurTijd", besteldeItem.InstuurTijd),
                    new SqlParameter("@MenuItemId", besteldeItem.menuItem.MenuItemId),
                    new SqlParameter("@BestellingsId", bestelling.bestellingId),
                    new SqlParameter("@Hoeveelheid", besteldeItem.Hoeveelheid)
                };
                ExecuteEditQuery(query, sqlParameters);
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
                    MenuId = Convert.ToInt32(row["MenuId"]),
                    IsAlcoholisch = (bool)row["Alcoholisch"]

                };

                BesteldeItem item = new BesteldeItem(_menuItem)
                {
                    BesteldItemId = Convert.ToInt32(row["BesteldItemId"]),
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = (DateTime)row["Instuurtijd"],
                    BestellingsID = Convert.ToInt32(row["BestellingsID"]),
                    Hoeveelheid = Convert.ToInt32(row["Hoeveelheid"]),
                    Naam = row["Naam"].ToString(),
                    status = (GerechtsStatus)row["GerechtsStatus"]

                };
                items.Add(item);
            }
            return items;
        }


    }
}
