using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ItemBereiderDao : BaseDao
    {
        
        public void ChangeKeukenStatus(Bestelling bestelling)
        {
            string query = $"UPDATE Keuken SET Status=@Status WHERE BestellingId = @BestellingId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Status", bestelling.status),
                new SqlParameter("@BestellingId", bestelling.bestellingId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public void ChangeBarStatus(Bestelling bestelling)
        {
            string query = $"UPDATE Bar SET Status=@Status WHERE BestellingId = @BestellingId;";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Status", bestelling.status),
                new SqlParameter("@BestellingId", bestelling.bestellingId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Bestelling> GetTafelBestellingKeuken(Tafel tafel)
        {
            string query = $"SELECT Naam, Bestellingen.BestellingsId, Status, Opmerking, Instuurtijd FROM Bestellingen \r\nJOIN Keuken ON Keuken.BestellingId = Bestellingen.BestellingsId\r\nJOIN BesteldeItems ON BesteldeItems.BestellingsId = Bestellingen.BestellingsId\r\nJOIN MenuItems ON MenuItems.MenuItemId = Besteldeitems.MenuItemId WHERE TableNr=@TableNr";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNr", tafel.Id),
            };
            return ReadBestelling(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Bestelling> GetTafelBestellingBar(Tafel tafel)
        {
            string query = $"SELECT Naam, Bestellingen.BestellingsId, Status, Opmerking, Instuurtijd FROM Bestellingen \r\nJOIN Bar ON Bar.BestellingId = Bestellingen.BestellingsId\r\nJOIN BesteldeItems ON BesteldeItems.BestellingsId = Bestellingen.BestellingsId\r\nJOIN MenuItems ON MenuItems.MenuItemId = Besteldeitems.MenuItemId WHERE TableNr=@TableNr";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNr", tafel.Id),
            };
            return ReadBestelling(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Bestelling> ReadBestelling(DataTable dataTable)
        {
            List<Bestelling> bestellingen = new List<Bestelling>();
            foreach (DataRow row in dataTable.Rows)
            {
                int bestellingId = Convert.ToInt32(row["BestellingsId"]);
                Bestelling bestelling = bestellingen.Find(b => b.bestellingId == bestellingId);

                if (bestelling == null)
                {
                    bestelling = new Bestelling
                    {
                        bestellingId = bestellingId,
                        status = (GerechtsStatus)Convert.ToInt32(row["Status"])
                    };
                    bestellingen.Add(bestelling);
                }

                BesteldeItem besteldeItem = new BesteldeItem(new MenuItem
                {
                    Naam = row["Naam"].ToString(),
                })
                {
                    Opmerking = row["Opmerking"].ToString(),
                    InstuurTijd = Convert.ToDateTime(row["Instuurtijd"]),
                };

                bestelling.BesteldeItems.Add(besteldeItem);
            }
            return bestellingen;
        }

        public List<BesteldeItem> GetAllBesteldeItems()
        {
            string query = @"
            SELECT BesteldeItems.BesteldItemId, 
            BesteldeItems.Opmerking, 
            BesteldeItems.Instuurtijd, 
            BesteldeItems.BestellingsId,    
            BesteldeItems.GerechtsStatus, 
            BesteldeItems.Hoeveelheid, 
            MenuItems.MenuItemId, 
            MenuItems.Naam, 
            MenuItems.Prijs, 
            MenuItems.Alcoholisch, 
            MenuItems.MenuId, 
            MenuItems.Voorraad 
            FROM BesteldeItems 
            JOIN MenuItems ON MenuItems.MenuItemId=BesteldeItems.MenuItemId 
            JOIN Bestellingen ON Bestellingen.BestellingsId = BesteldeItems.BesteldItemId 
            WHERE Instuurtijd >= DATEADD(day, -1, GETDATE())";
            return ReadTables(ExecuteSelectQuery(query));

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

        public void UpdateBestellingStatus(GerechtsStatus status, int besteldeItemId)

        {
            string query = "UPDATE BesteldeItems SET GerechtsStatus = @status WHERE BesteldItemId = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@status", (int)status),
                new SqlParameter("@id", besteldeItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
