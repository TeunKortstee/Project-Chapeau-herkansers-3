using DAL;
using Model;

namespace Service
{
    public class InkomenService
    {
        const bool betaald = true;

        private InkomenDao inkomenDao;

        public InkomenService()
        {
            this.inkomenDao = new InkomenDao();
        }
        public List<Inkomen> GetInkomens(BereidingsPlek bereidingsPlek)
        {
            return inkomenDao.GetInkomens(betaald, bereidingsPlek);
        }
        public void UpdateInkomen(List<BesteldeItem> besteldeItems)
        {
            foreach (BesteldeItem besteldeItem in besteldeItems)
            {
                double nieuweInkomen = besteldeItem.menuItem.Prijs * besteldeItem.Hoeveelheid;
                inkomenDao.UpdateInkomen(nieuweInkomen, besteldeItem.Hoeveelheid, besteldeItem.menuItem);
            }
        }
        public void InsertInkomen(MenuItem menuItem, BereidingsPlek bereidingsPlek)
        {
            inkomenDao.InsertInkomen(menuItem, bereidingsPlek);
        }
    }
}
