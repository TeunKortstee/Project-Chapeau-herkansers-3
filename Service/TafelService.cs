using DAL;
using Model;

namespace Service
{
    public class TafelService
    {
        private TafelDao dao;

        public TafelService()
        {
            this.dao = new TafelDao();
        }

        public List<Tafel> GetAllTafels()
        {
            return dao.GetAllTafels();
        }
        public void ChangeTafel(Tafel tafel)
        {
            dao.ChangeTafelStatus(tafel);
        }
    }
}
