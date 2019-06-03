using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class StavkeNarudzbe
    {
        public int StavkeNarudzbeId { get; set; }
        public int HranaId { get; set; }
        public int Kolicina { get; set; }
        public int NarudzbaId { get; set; }

        public virtual Proizvodi Hrana { get; set; }
        public virtual Narudzbe Narudzba { get; set; }
    }
}
