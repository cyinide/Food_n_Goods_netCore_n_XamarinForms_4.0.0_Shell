using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Narudzbe
    {
        public Narudzbe()
        {
            StavkeNarudzbe = new HashSet<StavkeNarudzbe>();
        }

        public int NarudzbaId { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public int? KuponId { get; set; }
        public int Status { get; set; }
        public double? UkupnaCijena { get; set; }
        public Guid Sifra { get; set; }
        public int NarucilacId { get; set; }

        public virtual Kuponi Kupon { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbe { get; set; }
    }
}
