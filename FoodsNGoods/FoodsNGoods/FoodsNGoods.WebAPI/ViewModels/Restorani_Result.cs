using FoodsNGoods.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsNGoods.WebAPI.ViewModels
{
    public class Restorani_Result
    {
        public int RestoranID { get; set; }
        public int BlokID { get; set; }
        public int MinimalnaCijenaNarudžbe { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public string Slogan { get; set; }
        public string Telefon { get; set; }
        public int VlasnikID { get; set; }
        public string VlasnikNaziv { get; set; }
        public string WebUrl { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public string BlokGradNaziv { get; set; }
        public string AdresaFullNaziv { get; set; }
        public byte[] SlikaBin { get; set; }

        public static Restorani_Result GetRestoraniResultInstance(Restorani obj)
        {
            return obj == null ? null : new Restorani_Result
            {
                RestoranID = obj.RestoranId,
                Adresa = obj.Adresa,
                BlokGradNaziv = obj.Blok.Naziv + ", " + obj.Blok.Grad.Naziv,
                BlokID = obj.BlokId,
                Email = obj.Email,
                MinimalnaCijenaNarudžbe = obj.MinimalnaCijenaNarudžbe,
                Naziv = obj.Naziv,
                Opis = obj.Opis,
                Slika = null,
                Slogan = obj.Slogan,
                Telefon = obj.Telefon,
                VlasnikID = obj.VlasnikId,
                VlasnikNaziv = obj.Vlasnik.Ime + " " + obj.Vlasnik.Prezime,
                WebUrl = obj.WebUrl,
                SlikaBin = obj.SlikaBin,
                AdresaFullNaziv = obj.Adresa + ", " + obj.Blok.Grad.Naziv
            };

        }

        public static List<Restorani_Result> GetRestoraniResultInstance(List<Restorani> obj)
        {
            List<Restorani_Result> restoraniList = new List<Restorani_Result>();
            foreach (var x in obj)
            {
                restoraniList.Add(Restorani_Result.GetRestoraniResultInstance(x));
            }
            return obj == null ? null : restoraniList;
        }

    }
}
