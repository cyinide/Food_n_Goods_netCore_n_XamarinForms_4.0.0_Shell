using FoodsNGoods.WebAPI.Model;
using FoodsNGoods.WebAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodsNGoods.WebAPI.Controllers
{
    [Route("api/Restorani")]
    public class RestoraniController : Controller
    {
        FoodsNGoodsContext context = new FoodsNGoodsContext();

        [HttpGet]
        public async Task<ActionResult<List<Restorani_Result>>> GetRestorani()
        {
            List<Restorani> restorani = await context.Restorani.Include(x => x.Vlasnik).Include(y => y.Blok.Grad).ToListAsync();

            if (restorani == null)
            {
                return NotFound();
            }

            return Ok(Restorani_Result.GetRestoraniResultInstance(restorani));
        }

        [Route("{korisnikId}/FavoriteRestorani")]
        [HttpGet]
        public async Task<ActionResult<List<Restorani_Result>>> GetFavourite(int korisnikId)
        {
            List<Restorani> restorani = await context.RestoraniOmiljeni.Where(X => X.KorisnikId == korisnikId).Select(x => x.Restoran).Include(x=>x.Blok.Grad).Include(x=>x.Vlasnik).ToListAsync();

            return Ok(Restorani_Result.GetRestoraniResultInstance(restorani));
        }

        [Route("{restoranId}/CountRestaurantLikes")]
        [HttpGet]
        public async Task<ActionResult<int>> CountRestaurantLikes(int restoranId)
        {
            int restoraniLikesCount = await context.RestoraniOmiljeni.Where(X => X.RestoranId == restoranId).CountAsync();

            return Ok(restoraniLikesCount);
        }

        [Route("{korisnikId}/ToggleLikeRestoran")]
        [HttpPost]
        public async Task<ActionResult> ToggleLikeRestoran(int korisnikId, [FromBody]int restoranId)
        {
            restoranId = 2;
            RestoraniOmiljeni restoranLike = await context.RestoraniOmiljeni.Where(x => x.KorisnikId == korisnikId && x.RestoranId == restoranId).FirstOrDefaultAsync();

            if (restoranLike == null)
            {
                context.RestoraniOmiljeni.Add(new RestoraniOmiljeni { KorisnikId = korisnikId, RestoranId = restoranId });
            }
            else
            {
                context.RestoraniOmiljeni.Remove(restoranLike);
            }
            context.SaveChanges();
            return Ok();
        }

    }
}