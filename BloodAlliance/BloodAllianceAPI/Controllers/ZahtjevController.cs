using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BloodAlliance.ModelsAPI;

namespace BloodAllianceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZahtjevController : ControllerBase
    {
        private readonly BloodAllianceContext _context;

        public ZahtjevController(BloodAllianceContext context)
        {
            _context = context;
        }

        // GET: api/Zahtjev
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Zahtjev>>> GetZahtjev()
        {
            return await _context.Zahtjev.ToListAsync();
        }

        // GET: api/Zahtjev/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Zahtjev>> GetZahtjev(int id)
        {
            var zahtjev = await _context.Zahtjev.FindAsync(id);

            if (zahtjev == null)
            {
                return NotFound();
            }

            return zahtjev;
        }

        // PUT: api/Zahtjev/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutZahtjev(int id, Zahtjev zahtjev)
        {
            if (id != zahtjev.ZahtjevId)
            {
                return BadRequest();
            }

            _context.Entry(zahtjev).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZahtjevExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Zahtjev
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Zahtjev>> PostZahtjev(Zahtjev zahtjev)
        {
            _context.Zahtjev.Add(zahtjev);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetZahtjev", new { id = zahtjev.ZahtjevId }, zahtjev);
        }

        // DELETE: api/Zahtjev/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Zahtjev>> DeleteZahtjev(int id)
        {
            var zahtjev = await _context.Zahtjev.FindAsync(id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            _context.Zahtjev.Remove(zahtjev);
            await _context.SaveChangesAsync();

            return zahtjev;
        }

        private bool ZahtjevExists(int id)
        {
            return _context.Zahtjev.Any(e => e.ZahtjevId == id);
        }
    }
}
