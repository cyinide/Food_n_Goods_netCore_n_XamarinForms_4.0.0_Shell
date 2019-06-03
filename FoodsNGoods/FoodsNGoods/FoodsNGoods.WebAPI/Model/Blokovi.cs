using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Blokovi
    {
        public Blokovi()
        {
            Narucioci = new HashSet<Narucioci>();
            Restorani = new HashSet<Restorani>();
        }

        public int BlokId { get; set; }
        public int GradId { get; set; }
        public string Naziv { get; set; }

        public virtual Gradovi Grad { get; set; }
        public virtual ICollection<Narucioci> Narucioci { get; set; }
        public virtual ICollection<Restorani> Restorani { get; set; }
    }
}
