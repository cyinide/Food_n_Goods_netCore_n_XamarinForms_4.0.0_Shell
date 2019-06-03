using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Narucioci
    {
        public Narucioci()
        {
            AuthTokeni = new HashSet<AuthTokeni>();
            Lajkovi = new HashSet<Lajkovi>();
            Recenzije = new HashSet<Recenzije>();
            RestoraniOmiljeni = new HashSet<RestoraniOmiljeni>();
        }

        public int KorisnikId { get; set; }
        public int BadgeId { get; set; }
        public int BlokId { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Password { get; set; }
        public string Prezime { get; set; }
        public string Telefon { get; set; }
        public string Username { get; set; }
        public string ImageUrl { get; set; }
        public string Adresa { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual Badgevi Badge { get; set; }
        public virtual Blokovi Blok { get; set; }
        public virtual ICollection<AuthTokeni> AuthTokeni { get; set; }
        public virtual ICollection<Lajkovi> Lajkovi { get; set; }
        public virtual ICollection<Recenzije> Recenzije { get; set; }
        public virtual ICollection<RestoraniOmiljeni> RestoraniOmiljeni { get; set; }
    }
}
