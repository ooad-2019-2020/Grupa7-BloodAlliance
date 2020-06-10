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
    public class ObavijestDonorController : ControllerBase
    {
        private readonly BloodAllianceContext _context;

        public ObavijestDonorController(BloodAllianceContext context)
        {
            _context = context;
        }

        // GET: api/ObavijestDonor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObavijestDonor>>> GetObavijestDonor()
        {
            return await _context.ObavijestDonor.ToListAsync();
        }

        // GET: api/ObavijestDonor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObavijestDonor>> GetObavijestDonor(int id)
        {
            var obavijestDonor = await _context.ObavijestDonor.FindAsync(id);

            if (obavijestDonor == null)
            {
                return NotFound();
            }

            return obavijestDonor;
        }

        // PUT: api/ObavijestDonor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObavijestDonor(int id, ObavijestDonor obavijestDonor)
        {
            if (id != obavijestDonor.ObavijestDonorId)
            {
                return BadRequest();
            }

            _context.Entry(obavijestDonor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObavijestDonorExists(id))
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

        // POST: api/ObavijestDonor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ObavijestDonor>> PostObavijestDonor(ObavijestDonor obavijestDonor)
        {
            _context.ObavijestDonor.Add(obavijestDonor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObavijestDonor", new { id = obavijestDonor.ObavijestDonorId }, obavijestDonor);
        }

        // DELETE: api/ObavijestDonor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ObavijestDonor>> DeleteObavijestDonor(int id)
        {
            var obavijestDonor = await _context.ObavijestDonor.FindAsync(id);
            if (obavijestDonor == null)
            {
                return NotFound();
            }

            _context.ObavijestDonor.Remove(obavijestDonor);
            await _context.SaveChangesAsync();

            return obavijestDonor;
        }

        private bool ObavijestDonorExists(int id)
        {
            return _context.ObavijestDonor.Any(e => e.ObavijestDonorId == id);
        }
    }
}
