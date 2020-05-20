using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodAlliance.Models;

namespace BloodAlliance.Controllers
{
    public class DonacijaController : Controller
    {
        private readonly BAContext _context;

        public DonacijaController(BAContext context)
        {
            _context = context;
        }

        // GET: Donacija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Donacija.ToListAsync());
        }

        // GET: Donacija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donacija = await _context.Donacija
                .FirstOrDefaultAsync(m => m.DonacijaId == id);
            if (donacija == null)
            {
                return NotFound();
            }

            return View(donacija);
        }

        // GET: Donacija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Donacija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DonacijaId,SifraDonacije,KrvnaGrupa,DatumDonacije,RhFaktor,ImeDoktora")] Donacija donacija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(donacija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(donacija);
        }

        // GET: Donacija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donacija = await _context.Donacija.FindAsync(id);
            if (donacija == null)
            {
                return NotFound();
            }
            return View(donacija);
        }

        // POST: Donacija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonacijaId,SifraDonacije,KrvnaGrupa,DatumDonacije,RhFaktor,ImeDoktora")] Donacija donacija)
        {
            if (id != donacija.DonacijaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donacija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonacijaExists(donacija.DonacijaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(donacija);
        }

        // GET: Donacija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donacija = await _context.Donacija
                .FirstOrDefaultAsync(m => m.DonacijaId == id);
            if (donacija == null)
            {
                return NotFound();
            }

            return View(donacija);
        }

        // POST: Donacija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donacija = await _context.Donacija.FindAsync(id);
            _context.Donacija.Remove(donacija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonacijaExists(int id)
        {
            return _context.Donacija.Any(e => e.DonacijaId == id);
        }
    }
}
