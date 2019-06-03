using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class RestoraniOmiljeni
    {
        public int RestoranOmiljeniId { get; set; }
        public int KorisnikId { get; set; }
        public int RestoranId { get; set; }

        public virtual Narucioci Korisnik { get; set; }
        public virtual Restorani Restoran { get; set; }
    }
}
