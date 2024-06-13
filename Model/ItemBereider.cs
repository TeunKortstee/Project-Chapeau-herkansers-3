using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ItemBereider
    {
        public int BesteldItemId { get; set; }
        public string? Opmerking { get; set; }
        public DateTime Instuurtijd { get; set; }
        public int MenuItemId { get; set; }
        public int BestellingsId { get; set; }
        public int Hoeveelheid { get; set; }
        public int PersoneelsId { get; set; }
        public string? Alcoholisch { get; set; }
        public string? Naam { get; set; }
        public int Voorraad { get; set; }

        public GerechtsStatus Status { get; set; }


        //dit model hoeft niet perse, gebruik bestaande models zoals besteldeitem
    }
}
