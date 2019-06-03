using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class TipoviKuhinje
    {
        public TipoviKuhinje()
        {
            Proizvodi = new HashSet<Proizvodi>();
        }

        public int TipKuhinjeId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public virtual ICollection<Proizvodi> Proizvodi { get; set; }
    }
}
