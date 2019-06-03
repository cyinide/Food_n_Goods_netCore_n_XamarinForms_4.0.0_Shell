using FoodsNGoods.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodsNGoods
{
    public class GlobalSettings
    {
        public static Narucioci_Result logiraniNarucilac { get; set; }
        public static ICollection<Restorani_Result> logiraniNarucilacOmiljeniRestorani { get; set; }
    }
}
