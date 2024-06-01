using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PersoneelService
    {
        private PersoneelDao personeelDao;

        public PersoneelService()
        {
            this.personeelDao = new PersoneelDao();
        }
    }
}
