using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Gradovi
    {
        public Gradovi()
        {
            Blokovi = new HashSet<Blokovi>();
        }

        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int PoštanskiBroj { get; set; }
        public string Drzava { get; set; }

        public virtual ICollection<Blokovi> Blokovi { get; set; }
    }
}
