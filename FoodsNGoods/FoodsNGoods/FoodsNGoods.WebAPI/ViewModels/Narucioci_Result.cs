using FoodsNGoods.WebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsNGoods.WebAPI.ViewModels
{
    public class Narucioci_Result
    {
        public int KorisnikID { get; set; }
        public int BadgeID { get; set; }
        public int BlokID { get; set; }
        public Nullable<System.DateTime> DatumKreiranja { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Password { get; set; }//???
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Username { get; set; }
        public string ImageUrl { get; set; }
        public string Adresa { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }


        public static Narucioci_Result GetNaruciociResultInstance(Narucioci obj)
        {
            return obj == null ? null : new Narucioci_Result
            {
                KorisnikID = obj.KorisnikId,
                BadgeID = obj.BadgeId,
                DatumKreiranja = obj.DatumKreiranja,
                ImageUrl = obj.ImageUrl,
                LozinkaHash = obj.LozinkaHash,
                LozinkaSalt = obj.LozinkaSalt,
                Username = obj.Username,
                Ime = obj.Ime,
                Password = obj.Password, //ispraviti
                Prezime = obj.Prezime,
                Adresa = obj.Adresa,
                BlokID = obj.BlokId,
                Email = obj.Email,
                Telefon = obj.Telefon,
            };
        }
    }
}
