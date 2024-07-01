using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Inkomen
    {
        public int InkomenId { get; set; }
        public double TotaleInkomen { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Hoeveelheid { get; set; }
        public BereidingsPlek BereidingsPlek { get; set; }

        public Inkomen()
        {
        }
    }
}
