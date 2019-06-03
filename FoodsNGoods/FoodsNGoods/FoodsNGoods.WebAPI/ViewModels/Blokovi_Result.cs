using FoodsNGoods.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsNGoods.WebAPI.ViewModels
{
    public class Blokovi_Result
    {
        public int BlokID { get; set; }
        public int GradID { get; set; }
        public string BlokGradNaziv { get; set; }


        public static Blokovi_Result GetBlokoviResultInstance(Blokovi obj)
        {
            return obj == null ? null : new Blokovi_Result
            {
                BlokID = obj.BlokId,
                GradID = obj.GradId,
                BlokGradNaziv = obj.Naziv + ", " + obj.Grad.Naziv
            };
        }

        public static List<Blokovi_Result> GetBlokoviResultInstance(List<Blokovi> obj)
        {
            List<Blokovi_Result> blokoviList = new List<Blokovi_Result>();
            foreach (var x in obj)
            {
                blokoviList.Add(Blokovi_Result.GetBlokoviResultInstance(x));
            }
            return obj == null ? null : blokoviList;
        }
    }
}
