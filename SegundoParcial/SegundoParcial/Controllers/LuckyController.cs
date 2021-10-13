using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegundoParcial.Data;
using SegundoParcial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuckyController : ControllerBase
    {
        private readonly AppDbContext _context;
        public LuckyController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Suerte>> GetDato()
        {
            var list = await _context.Suertes.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var dato = list[index];

            if (dato == null)
            {
                return NoContent();
            }
            return dato;
        }

    }
}
