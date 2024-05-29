﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Service
{
    public class RekeningService
    {
        private RekeningDao rekeningDao;

        public RekeningService()
        {
            rekeningDao = new RekeningDao();
        }
        public Rekening GetRekening(int bestellingID)
        {
            return rekeningDao.GetRekening(bestellingID);

        }
    }
}
