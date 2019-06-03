using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Restorani
    {
        public Restorani()
        {
            Jelovnici = new HashSet<Jelovnici>();
            Lajkovi = new HashSet<Lajkovi>();
            Recenzije = new HashSet<Recenzije>();
            RestoraniOmiljeni = new HashSet<RestoraniOmiljeni>();
            VrijemeRada = new HashSet<VrijemeRada>();
        }

        public int RestoranId { get; set; }
        public int BlokId { get; set; }
        public int MinimalnaCijenaNarudžbe { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Slika { get; set; }
        public string Slogan { get; set; }
        public string Telefon { get; set; }
        public int VlasnikId { get; set; }
        public string WebUrl { get; set; }
        public string Adresa { get; set; }
        public string Email { get; set; }
        public byte[] SlikaBin { get; set; }

        public virtual Blokovi Blok { get; set; }
        public virtual Vlasnici Vlasnik { get; set; }
        public virtual ICollection<Jelovnici> Jelovnici { get; set; }
        public virtual ICollection<Lajkovi> Lajkovi { get; set; }
        public virtual ICollection<Recenzije> Recenzije { get; set; }
        public virtual ICollection<RestoraniOmiljeni> RestoraniOmiljeni { get; set; }
        public virtual ICollection<VrijemeRada> VrijemeRada { get; set; }
    }
}
