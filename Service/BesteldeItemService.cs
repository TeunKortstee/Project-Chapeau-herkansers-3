namespace Service
{
    public class BesteldeItemService
    {
        private BesteldeItemDao besteldeItemDao;

        public BesteldeItemService()
        {
            besteldeItemDao = new BesteldeItemDao();
        }
        //public List<BesteldItem> GetItemsFromBestelling(int bestellingID)
        //{
        //    return besteldeItemDao.GetItemsFromBestelling(bestellingID);

        //}

        public Bestelling BestellingAanmaken(Bestelling bestelling, Personeel personeel)
        {

            public void BestellingItemsAanmaken(Bestelling bestelling)
            {
                besteldeItemDao.BestellingItemsAanmaken(bestelling);
            }
        }
    }
