using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Recenzije
    {
        public int RestoranRecenzijaId { get; set; }
        public DateTime Datum { get; set; }
        public int NarucilacId { get; set; }
        public string Recenzija { get; set; }
        public int RestoranId { get; set; }

        public virtual Narucioci Narucilac { get; set; }
        public virtual Restorani Restoran { get; set; }
    }
}
