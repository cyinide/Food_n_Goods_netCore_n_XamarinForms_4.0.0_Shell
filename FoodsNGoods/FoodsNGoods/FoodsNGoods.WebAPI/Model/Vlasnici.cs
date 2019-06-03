using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Vlasnici
    {
        public Vlasnici()
        {
            AuthTokeni = new HashSet<AuthTokeni>();
            Restorani = new HashSet<Restorani>();
        }

        public int KorisnikId { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Password { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }

        public virtual ICollection<AuthTokeni> AuthTokeni { get; set; }
        public virtual ICollection<Restorani> Restorani { get; set; }
    }
}
