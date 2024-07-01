using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class GesplitsteRekeningObject
    {
        public BetaalMethode betaalMethode { get; set; }
        public double betaling { get; set; }
        public double fooi { get; set; }
        public GesplitsteRekeningObject(BetaalMethode methode, double betaling, double fooi)
        {
            this.betaalMethode = methode;
            this.betaling = betaling;
            this.fooi = fooi;
        }
    }
}