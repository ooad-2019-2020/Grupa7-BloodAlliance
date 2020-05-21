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
    public class ZdravstvenaHistorijaController : Controller
    {
        private readonly BAContext _context;

        public ZdravstvenaHistorijaController(BAContext context)
        {
            _context = context;
        }

        // GET: ZdravstvenaHistorija
        public async Task<IActionResult> Index()
        {
            return View(await _context.ZdravstvenaHistorija.ToListAsync());
        }

        // GET: ZdravstvenaHistorija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdravstvenaHistorija = await _context.ZdravstvenaHistorija
                .FirstOrDefaultAsync(m => m.ZdravstvenaHistorijaId == id);
            if (zdravstvenaHistorija == null)
            {
                return NotFound();
            }

            return View(zdravstvenaHistorija);
        }

        // GET: ZdravstvenaHistorija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ZdravstvenaHistorija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ZdravstvenaHistorijaId,BolestiRespiratornogSistema,SrcaniProblemi,PolnoPrenosiveBolesti,HormonalniPoremecaji,Secer,HronicneBolesti,NervniProblemi")] ZdravstvenaHistorija zdravstvenaHistorija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zdravstvenaHistorija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zdravstvenaHistorija);
        }

        // GET: ZdravstvenaHistorija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdravstvenaHistorija = await _context.ZdravstvenaHistorija.FindAsync(id);
            if (zdravstvenaHistorija == null)
            {
                return NotFound();
            }
            return View(zdravstvenaHistorija);
        }

        // POST: ZdravstvenaHistorija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZdravstvenaHistorijaId,BolestiRespiratornogSistema,SrcaniProblemi,PolnoPrenosiveBolesti,HormonalniPoremecaji,Secer,HronicneBolesti,NervniProblemi")] ZdravstvenaHistorija zdravstvenaHistorija)
        {
            if (id != zdravstvenaHistorija.ZdravstvenaHistorijaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zdravstvenaHistorija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZdravstvenaHistorijaExists(zdravstvenaHistorija.ZdravstvenaHistorijaId))
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
            return View(zdravstvenaHistorija);
        }

        // GET: ZdravstvenaHistorija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zdravstvenaHistorija = await _context.ZdravstvenaHistorija
                .FirstOrDefaultAsync(m => m.ZdravstvenaHistorijaId == id);
            if (zdravstvenaHistorija == null)
            {
                return NotFound();
            }

            return View(zdravstvenaHistorija);
        }

        // POST: ZdravstvenaHistorija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zdravstvenaHistorija = await _context.ZdravstvenaHistorija.FindAsync(id);
            _context.ZdravstvenaHistorija.Remove(zdravstvenaHistorija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZdravstvenaHistorijaExists(int id)
        {
            return _context.ZdravstvenaHistorija.Any(e => e.ZdravstvenaHistorijaId == id);
        }
    }
}
