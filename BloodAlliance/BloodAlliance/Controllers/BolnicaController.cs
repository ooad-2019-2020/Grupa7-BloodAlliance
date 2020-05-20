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
    public class BolnicaController : Controller
    {
        private readonly BAContext _context;

        public BolnicaController(BAContext context)
        {
            _context = context;
        }

        // GET: Bolnica
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bolnica.ToListAsync());
        }

        // GET: Bolnica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolnica = await _context.Bolnica
                .FirstOrDefaultAsync(m => m.BolnicaId == id);
            if (bolnica == null)
            {
                return NotFound();
            }

            return View(bolnica);
        }

        // GET: Bolnica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bolnica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BolnicaId,Naziv,Username,Password,Email,BrojTelefona,Adresa")] Bolnica bolnica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bolnica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bolnica);
        }

        // GET: Bolnica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolnica = await _context.Bolnica.FindAsync(id);
            if (bolnica == null)
            {
                return NotFound();
            }
            return View(bolnica);
        }

        // POST: Bolnica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BolnicaId,Naziv,Username,Password,Email,BrojTelefona,Adresa")] Bolnica bolnica)
        {
            if (id != bolnica.BolnicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bolnica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BolnicaExists(bolnica.BolnicaId))
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
            return View(bolnica);
        }

        // GET: Bolnica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolnica = await _context.Bolnica
                .FirstOrDefaultAsync(m => m.BolnicaId == id);
            if (bolnica == null)
            {
                return NotFound();
            }

            return View(bolnica);
        }

        // POST: Bolnica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bolnica = await _context.Bolnica.FindAsync(id);
            _context.Bolnica.Remove(bolnica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BolnicaExists(int id)
        {
            return _context.Bolnica.Any(e => e.BolnicaId == id);
        }
    }
}
