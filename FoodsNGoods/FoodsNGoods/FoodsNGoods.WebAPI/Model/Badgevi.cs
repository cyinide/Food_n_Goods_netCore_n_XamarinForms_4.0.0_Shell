using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Badgevi
    {
        public Badgevi()
        {
            Narucioci = new HashSet<Narucioci>();
        }

        public int BadgeId { get; set; }
        public int BrojBodova { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Narucioci> Narucioci { get; set; }
    }
}
