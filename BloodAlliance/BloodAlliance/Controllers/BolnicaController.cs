using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodAlliance.Models;
using Microsoft.AspNetCore.Identity;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace BloodAlliance.Controllers
{
    public class BolnicaController : Controller
    {
        private readonly BAContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BolnicaController(BAContext context, UserManager<IdentityUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;
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
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bolnica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("BolnicaId,Naziv,Email,BrojTelefona,Adresa")] Bolnica bolnica)
        {

            bolnica.Username = GenerisiUsername(bolnica.Naziv);
            bolnica.Password = "Test123!";
            var user = new IdentityUser { UserName = bolnica.Username, Email = bolnica.Email, PhoneNumber = bolnica.BrojTelefona };
            var result = await _userManager.CreateAsync(user, bolnica.Password);
            await _userManager.AddToRoleAsync(user, "Bolnica");


            await _context.Bolnica.AddAsync(bolnica);
            await _context.SaveChangesAsync();

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

        private string GenerisiUsername(string naziv)
        {
            string username = "";

            List<String> nazivi = naziv.Split(' ').ToList();

            foreach (var n in nazivi)
            {
                if (username.Equals(""))
                {
                    username = username + n.ToLower();
                }
                else
                {
                    username = username + '.' + n.ToLower();
                }

            }

            StringBuilder builder = new StringBuilder(username);

            for (int i = 0; i < builder.Length; i++)
            {
                if (builder[i] == 'č' || builder[i] == 'ć')
                {
                    builder[i] = 'c';
                }
                else if (builder[i] == 'đ')
                {
                    builder[i] = 'd';
                }
                else if (builder[i] == 'š')
                {
                    builder[i] = 's';
                }
                else if (builder[i] == 'ž')
                {
                    builder[i] = 'z';
                }
            }

            username = builder.ToString();

            int dodatak = 1;

            while (ProvjeriUsername(username))
            {
                username = username + (dodatak++).ToString();
            }


            return username;
        }

        private bool ProvjeriUsername(string username)
        {
            List<Bolnica> bolnice = _context.Bolnica.ToList();

            foreach (var bolnica in bolnice)
            {
                if (bolnica.Username.Equals(username)) return true;
            }
            return false;
        }
        public async Task<IActionResult> PregledObavijesti()
        {
            /*if (name == null)
            {
                return NotFound();
            }*/

            var user = _httpContextAccessor.HttpContext.User;
            var userDb = await _userManager.GetUserAsync(user);
            //if (userDb != null && user.IsInRole("Bolnica"))
            //{
                var bolnica = _context.Bolnica.FirstOrDefault(b => userDb.UserName.Equals(b.Username));
                
            //}

            //var bolnica = await _context.Bolnica.FirstOrDefaultAsync(bolnica => bolnica.Username.Equals(name));
            var id = bolnica.BolnicaId;

            var obavijesti = _context.ObavijestBolnica.AsQueryable();

            obavijesti = obavijesti.Where(obavijest => obavijest.BolnicaId == id);


            return View(await obavijesti.ToListAsync());
        }
    }

}
