using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Jelovnici
    {
        public Jelovnici()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int JelovnikId { get; set; }
        public bool Aktivan { get; set; }
        public string Opis { get; set; }
        public int RestoranId { get; set; }
        public string Slika { get; set; }

        public virtual Restorani Restoran { get; set; }
        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
