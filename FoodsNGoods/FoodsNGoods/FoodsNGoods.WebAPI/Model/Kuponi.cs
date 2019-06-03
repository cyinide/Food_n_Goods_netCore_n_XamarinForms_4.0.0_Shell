using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Kuponi
    {
        public Kuponi()
        {
            Narudzbe = new HashSet<Narudzbe>();
        }

        public int KuponId { get; set; }
        public string Opis { get; set; }
        public double Vrijednost { get; set; }

        public virtual ICollection<Narudzbe> Narudzbe { get; set; }
    }
}
