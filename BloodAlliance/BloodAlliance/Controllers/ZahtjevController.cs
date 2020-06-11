using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodAlliance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BloodAlliance.Controllers
{
    public class ZahtjevController : Controller
    {
        private readonly BAContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;

        public ZahtjevController(BAContext context, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        // GET: Zahtjev
        public async Task<IActionResult> Index()
        {
            return View(await _context.Zahtjev.ToListAsync());
        }

        // GET: Zahtjev/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev
                .FirstOrDefaultAsync(m => m.ZahtjevId == id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            return View(zahtjev);
        }

        // GET: Zahtjev/Create
        [Authorize(Roles = "Bolnica")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zahtjev/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Bolnica")]
        public async Task<IActionResult> Create([Bind("ZahtjevId,Datum,KrvnaGrupa,RhFaktor,Kolicina")] Zahtjev zahtjev)
        {
            if (ModelState.IsValid)
            {
                var user = _httpContextAccessor.HttpContext.User;
                var userDb = await _userManager.GetUserAsync(user);
                if (userDb != null && user.IsInRole("Bolnica"))
                {
                    var bolnica = _context.Bolnica.FirstOrDefault(b => userDb.UserName.Equals(b.Username));
                    zahtjev.NazivBolnice = bolnica.Naziv;

                    _context.Add(zahtjev);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index","Bolnica");
                }
            }
            return View(zahtjev);
        }

        // GET: Zahtjev/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev.FindAsync(id);
            if (zahtjev == null)
            {
                return NotFound();
            }
            return View(zahtjev);
        }

        // POST: Zahtjev/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ZahtjevId,Datum,KrvnaGrupa")] Zahtjev zahtjev)
        {
            if (id != zahtjev.ZahtjevId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zahtjev);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZahtjevExists(zahtjev.ZahtjevId))
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
            return View(zahtjev);
        }

        // GET: Zahtjev/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zahtjev = await _context.Zahtjev
                .FirstOrDefaultAsync(m => m.ZahtjevId == id);
            if (zahtjev == null)
            {
                return NotFound();
            }

            return View(zahtjev);
        }

        // POST: Zahtjev/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zahtjev = await _context.Zahtjev.FindAsync(id);

            var bolnica = await _context.Bolnica.FirstOrDefaultAsync(bolnica => bolnica.Naziv.Equals(zahtjev.NazivBolnice));
            var obavijest = new ObavijestBolnica();
            obavijest.BolnicaId = bolnica.BolnicaId;
            obavijest.KrvnaGrupa = zahtjev.KrvnaGrupa;
            obavijest.Kolicina = zahtjev.Kolicina;
            obavijest.Obavijest = "Vas zahtjev je potvrdjen. Potrebna kolicna krvi je poslana na vasu adresu.";
            _context.ObavijestBolnica.Add(obavijest);
            await _context.SaveChangesAsync();

            _context.Zahtjev.Remove(zahtjev);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZahtjevExists(int id)
        {
            return _context.Zahtjev.Any(e => e.ZahtjevId == id);
        }
    }
}
