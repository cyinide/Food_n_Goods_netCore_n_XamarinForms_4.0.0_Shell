using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class Proizvodi
    {
        public Proizvodi()
        {
            HranaPrilogHrana = new HashSet<HranaPrilog>();
            HranaPrilogPrilog = new HashSet<HranaPrilog>();
            StavkeNarudzbe = new HashSet<StavkeNarudzbe>();
        }

        public int HranaId { get; set; }
        public double Cijena { get; set; }
        public int JelovnikId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string Prilog { get; set; }
        public int Sifra { get; set; }
        public string Slika { get; set; }
        public int TipKuhinjeId { get; set; }

        public virtual Jelovnici Jelovnik { get; set; }
        public virtual TipoviKuhinje TipKuhinje { get; set; }
        public virtual ICollection<HranaPrilog> HranaPrilogHrana { get; set; }
        public virtual ICollection<HranaPrilog> HranaPrilogPrilog { get; set; }
        public virtual ICollection<StavkeNarudzbe> StavkeNarudzbe { get; set; }
    }
}
