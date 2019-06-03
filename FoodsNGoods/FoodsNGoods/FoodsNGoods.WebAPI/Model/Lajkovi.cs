using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Lajkovi
    {
        public int RestoranLikeId { get; set; }
        public int NarucilacId { get; set; }
        public int RestoranId { get; set; }
        public DateTime Datum { get; set; }

        public virtual Narucioci Narucilac { get; set; }
        public virtual Restorani Restoran { get; set; }
    }
}
