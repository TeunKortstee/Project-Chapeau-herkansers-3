using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class SplitBillItemObj
    {


        public BetaalMethode method { get; set; }

        public double payment { get; set; }

        public double tip { get; set; }

        public SplitBillItemObj(BetaalMethode method, double payment, double tip)
        {
            this.method = method;
            this.payment = payment;
            this.tip = tip;
        }



    }
}