using System;
using System.Collections.Generic;

namespace FoodsNGoods.WebAPI.Model
{
    public partial class AuthTokeni
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DateTime DatumGenerisanja { get; set; }
        public int? ModeratorId { get; set; }
        public int? NarucilacId { get; set; }
        public int? VlasnikId { get; set; }
        public string Ip { get; set; }

        public virtual Moderatori Moderator { get; set; }
        public virtual Narucioci Narucilac { get; set; }
        public virtual Vlasnici Vlasnik { get; set; }
    }
}
