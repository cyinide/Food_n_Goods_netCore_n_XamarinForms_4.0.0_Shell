using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class HranaPrilog
    {
        public int HranaId { get; set; }
        public int PrilogId { get; set; }

        public virtual Proizvodi Hrana { get; set; }
        public virtual Proizvodi Prilog { get; set; }
    }
}
