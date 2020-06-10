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
    public class ObavijestBolnicaController : ControllerBase
    {
        private readonly BloodAllianceContext _context;

        public ObavijestBolnicaController(BloodAllianceContext context)
        {
            _context = context;
        }

        // GET: api/ObavijestBolnica
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObavijestBolnica>>> GetObavijestBolnica()
        {
            return await _context.ObavijestBolnica.ToListAsync();
        }

        // GET: api/ObavijestBolnica/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObavijestBolnica>> GetObavijestBolnica(int id)
        {
            var obavijestBolnica = await _context.ObavijestBolnica.FindAsync(id);

            if (obavijestBolnica == null)
            {
                return NotFound();
            }

            return obavijestBolnica;
        }

        // PUT: api/ObavijestBolnica/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObavijestBolnica(int id, ObavijestBolnica obavijestBolnica)
        {
            if (id != obavijestBolnica.ObavijestBolnicaId)
            {
                return BadRequest();
            }

            _context.Entry(obavijestBolnica).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObavijestBolnicaExists(id))
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

        // POST: api/ObavijestBolnica
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ObavijestBolnica>> PostObavijestBolnica(ObavijestBolnica obavijestBolnica)
        {
            _context.ObavijestBolnica.Add(obavijestBolnica);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObavijestBolnica", new { id = obavijestBolnica.ObavijestBolnicaId }, obavijestBolnica);
        }

        // DELETE: api/ObavijestBolnica/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ObavijestBolnica>> DeleteObavijestBolnica(int id)
        {
            var obavijestBolnica = await _context.ObavijestBolnica.FindAsync(id);
            if (obavijestBolnica == null)
            {
                return NotFound();
            }

            _context.ObavijestBolnica.Remove(obavijestBolnica);
            await _context.SaveChangesAsync();

            return obavijestBolnica;
        }

        private bool ObavijestBolnicaExists(int id)
        {
            return _context.ObavijestBolnica.Any(e => e.ObavijestBolnicaId == id);
        }
    }
}
