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
    public class DonacijaController : ControllerBase
    {
        private readonly BloodAllianceContext _context;

        public DonacijaController(BloodAllianceContext context)
        {
            _context = context;
        }

        // GET: api/Donacija
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Donacija>>> GetDonacija()
        {
            return await _context.Donacija.ToListAsync();
        }

        // GET: api/Donacija/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Donacija>> GetDonacija(int id)
        {
            var donacija = await _context.Donacija.FindAsync(id);

            if (donacija == null)
            {
                return NotFound();
            }

            return donacija;
        }

        // PUT: api/Donacija/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDonacija(int id, Donacija donacija)
        {
            if (id != donacija.DonacijaId)
            {
                return BadRequest();
            }

            _context.Entry(donacija).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DonacijaExists(id))
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

        // POST: api/Donacija
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Donacija>> PostDonacija(Donacija donacija)
        {
            _context.Donacija.Add(donacija);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDonacija", new { id = donacija.DonacijaId }, donacija);
        }

        // DELETE: api/Donacija/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Donacija>> DeleteDonacija(int id)
        {
            var donacija = await _context.Donacija.FindAsync(id);
            if (donacija == null)
            {
                return NotFound();
            }

            _context.Donacija.Remove(donacija);
            await _context.SaveChangesAsync();

            return donacija;
        }

        private bool DonacijaExists(int id)
        {
            return _context.Donacija.Any(e => e.DonacijaId == id);
        }
    }
}
