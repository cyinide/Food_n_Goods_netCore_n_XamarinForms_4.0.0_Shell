using FoodsNGoods.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsNGoods.WebAPI.ViewModels
{
    public class Proizvodi_Result
    {
        public int HranaID { get; set; }
        public double Cijena { get; set; }
        public int JelovnikID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Prilog { get; set; }
        public int Sifra { get; set; }
        public string Slika { get; set; }
        public int TipKuhinjeID { get; set; }


        public static Proizvodi_Result GetProizvodiResultInstance(Proizvodi obj)
        {
            return obj == null ? null : new Proizvodi_Result
            {
                HranaID = obj.HranaId,
                Cijena = obj.Cijena,
                JelovnikID = obj.JelovnikId,
                Naziv = obj.Naziv,
                Opis = obj.Opis,
                Prilog = obj.Prilog,
                Sifra = obj.Sifra,
                Slika = obj.Slika,
                TipKuhinjeID = obj.TipKuhinjeId
            };

        }

        public static List<Proizvodi_Result> GetProizvodiResultInstance(List<Proizvodi> obj)
        {
            List<Proizvodi_Result> restoraniList = new List<Proizvodi_Result>();
            foreach (var x in obj)
            {
                restoraniList.Add(Proizvodi_Result.GetProizvodiResultInstance(x));
            }
            return obj == null ? null : restoraniList;
        }
    }
}
