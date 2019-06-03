using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Moderatori
    {
        public Moderatori()
        {
            AuthTokeni = new HashSet<AuthTokeni>();
        }

        public int KorisnikId { get; set; }
        public DateTime? DatumKreiranja { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Permisije { get; set; }
        public string Username { get; set; }

        public virtual ICollection<AuthTokeni> AuthTokeni { get; set; }
    }
}
