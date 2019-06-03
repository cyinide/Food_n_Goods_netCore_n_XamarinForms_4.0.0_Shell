using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class VrijemeRada
    {
        public int RadnoVrijemeId { get; set; }
        public int Dan { get; set; }
        public int RestoranId { get; set; }
        public TimeSpan VrijemeOtvaranja { get; set; }
        public TimeSpan VrijemeZatvaranja { get; set; }

        public virtual Restorani Restoran { get; set; }
    }
}
