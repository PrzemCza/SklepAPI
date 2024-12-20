using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SklepAPI.Data;
using SklepAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SklepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProduktyController : ControllerBase
    {
        private readonly SklepContext _context;

        public ProduktyController(SklepContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produkt>>> GetProdukty()
        {
            return await _context.Produkty.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Produkt>> PostProdukt(Produkt produkt)
        {
            _context.Produkty.Add(produkt);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetProdukt", new { id = produkt.Id }, produkt);
        }
    }
}