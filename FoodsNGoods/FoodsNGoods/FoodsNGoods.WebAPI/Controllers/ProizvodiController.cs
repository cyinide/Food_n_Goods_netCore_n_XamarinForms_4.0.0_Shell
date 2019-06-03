using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodsNGoods.WebAPI.Model;
using FoodsNGoods.WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodsNGoods.WebAPI.Controllers
{
    [Route("api/Proizvodi")]
    public class ProizvodiController : Controller
    {
        FoodsNGoodsContext context = new FoodsNGoodsContext();

        [Route("{restoranId}/GetProizvodiByRestoran")]
        [HttpGet]
        public async Task<ActionResult<Proizvodi_Result>> GetProizvodiByRestoran(int restoranId)
        {
            List<Proizvodi> proizvodi = await context.Proizvodi.Where(x => x.Jelovnik.RestoranId == restoranId).ToListAsync();

            return Ok(Proizvodi_Result.GetProizvodiResultInstance(proizvodi));

        }
    }
}