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

    [Route("api/Auth")]
    [ApiController]
    public class AuthController : Controller
    {
        FoodsNGoodsContext context = new FoodsNGoodsContext();

        [HttpGet]
        public async Task<ActionResult<Narucioci_Result>> Login([FromQuery]string username)
        {
            var narucilac = await context.Narucioci.Where(x => x.Username == username).FirstOrDefaultAsync();

            if (narucilac != null)
            {
               //return StatusCode(StatusCodes.Status200OK, Narucioci_Result.GetNaruciociResultInstance(narucilac));
               return Ok(Narucioci_Result.GetNaruciociResultInstance(narucilac));
            }

            return NotFound();
            //return StatusCode(StatusCodes.Status404NotFound);
        }

        [HttpPost]
        public async Task<ActionResult<Narucioci>> Register([FromBody] Narucioci obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            context.Narucioci.Add(obj);
            await context.SaveChangesAsync();

            return Ok(obj);
        }
    }
}