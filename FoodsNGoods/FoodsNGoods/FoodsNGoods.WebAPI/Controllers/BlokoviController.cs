using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodsNGoods.WebAPI.Model;
using FoodsNGoods.WebAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodsNGoods.WebAPI.Controllers
{
    [Route("api/Blokovi")]
    public class BlokoviController : Controller
    {
        FoodsNGoodsContext context = new FoodsNGoodsContext();

        [HttpGet]
        public async Task<ActionResult<Blokovi_Result>> GetBlokovi()
        {
            List<Blokovi> blokovi = await context.Blokovi.Include(x => x.Grad).ToListAsync();

            if (blokovi != null)
            {
                return Ok(Blokovi_Result.GetBlokoviResultInstance(blokovi));
            }

            return NotFound();
        }
    }
}