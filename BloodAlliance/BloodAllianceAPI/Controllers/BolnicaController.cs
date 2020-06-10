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
    public class BolnicaController : ControllerBase
    {
        private readonly BloodAllianceContext _context;

        public BolnicaController(BloodAllianceContext context)
        {
            _context = context;
        }

        // GET: api/Bolnica
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bolnica>>> GetBolnica()
        {
            return await _context.Bolnica.ToListAsync();
        }

        // GET: api/Bolnica/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bolnica>> GetBolnica(int id)
        {
            var bolnica = await _context.Bolnica.FindAsync(id);

            if (bolnica == null)
            {
                return NotFound();
            }

            return bolnica;
        }

        // PUT: api/Bolnica/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBolnica(int id, Bolnica bolnica)
        {
            if (id != bolnica.BolnicaId)
            {
                return BadRequest();
            }

            _context.Entry(bolnica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BolnicaExists(id))
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

        // POST: api/Bolnica
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Bolnica>> PostBolnica(Bolnica bolnica)
        {
            _context.Bolnica.Add(bolnica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBolnica", new { id = bolnica.BolnicaId }, bolnica);
        }

        // DELETE: api/Bolnica/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Bolnica>> DeleteBolnica(int id)
        {
            var bolnica = await _context.Bolnica.FindAsync(id);
            if (bolnica == null)
            {
                return NotFound();
            }

            _context.Bolnica.Remove(bolnica);
            await _context.SaveChangesAsync();

            return bolnica;
        }

        private bool BolnicaExists(int id)
        {
            return _context.Bolnica.Any(e => e.BolnicaId == id);
        }
    }
}
