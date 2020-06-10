using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BloodAlliance.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using BloodAlliance.Areas.Identity.Pages.Account;
using Microsoft.AspNetCore.Authentication;
using System.Text;

namespace BloodAlliance.Controllers
{
    public class DonorController : Controller
    {
        private readonly BAContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;

        public List<AuthenticationScheme> ExternalLogins { get; private set; }

        public DonorController(BAContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Donor
        public async Task<IActionResult> Pretraga(string upit)
        {
            var donori = _context.Donor.AsQueryable();
            foreach (var donor in donori)
            {
                donor.PromijeniStatus();
                _context.Update(donor);
                _context.SaveChangesAsync();
            }

            if (!string.IsNullOrEmpty(upit))
            {
                donori = donori.Where(d => d.KrvnaGrupa.Contains(upit));
            }

            return View(await donori.ToListAsync());
        }

        public IActionResult Donor (string? username)
        {
            Donor donor = _context.Donor.FirstOrDefault(donor => donor.Username == username);

            statusDonora stariStatus = donor.StatusDonora;


            ViewBag.Id = donor.DonorId;
            ViewBag.Ime = donor.Ime;
            ViewBag.Prezime = donor.Prezime;
            ViewBag.Username = donor.Username;
            ViewBag.Email = donor.Email;
            ViewBag.BrojTelefona = donor.BrojTelefona;
            ViewBag.Jmbg = donor.Jmbg;
            ViewBag.KrvnaGrupa = donor.KrvnaGrupa;
            ViewBag.RhFaktor = donor.RhFaktor;
            ViewBag.BrojDarivanja = donor.BrojDarivanja;
            ViewBag.TjelesnaTezina = donor.TjelesnaTezina;
            ViewBag.MjestoDarivanja = donor.MjestoDarivanja;
            ViewBag.DatumPosljednjeDonacije = donor.DatumPosljednjeDonacije;
            ViewBag.Hemoglobin = donor.Hemoglobin;
            ViewBag.KrvniPritisak = donor.KrvniPritisak;
            ViewBag.Pol = donor.Pol;
            ViewBag.StatusDonora = donor.StatusDonora;

            return View();
        }

        // GET: Donor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donor
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // GET: Donor/Create
        //[Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Donor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create([Bind("DonorId,Ime,Prezime,Email,BrojTelefona,Jmbg,KrvnaGrupa,RhFaktor,BrojDarivanja,TjelesnaTezina,MjestoDarivanja,DatumPosljednjeDonacije,Hemoglobin,KrvniPritisak")] Donor donor, string returnUrl)
        {
            donor.Username = GenerisiUsername(donor.Ime, donor.Prezime);
            donor.Password = donor.Jmbg + donor.Ime.Substring(0, 1).ToLower() + "." + donor.Prezime.Substring(0, 1).ToUpper();
            donor.StatusDonora = statusDonora.neMozeDatiKrv;

            var user = new IdentityUser { UserName = donor.Username, Email = donor.Email, PhoneNumber = donor.BrojTelefona };
            var result = await _userManager.CreateAsync(user, donor.Password);
            await _userManager.AddToRoleAsync(user, "Donor");

            
            await _context.Donor.AddAsync(donor);
            await _context.SaveChangesAsync();

            return View(donor);
        }

        // GET: Donor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donor.FindAsync(id);
            if (donor == null)
            {
                return NotFound();
            }
            return View(donor);
        }

        // POST: Donor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DonorId,Ime,Prezime,Username,Password,Email,BrojTelefona,Jmbg,KrvnaGrupa,RhFaktor,BrojDarivanja,TjelesnaTezina,MjestoDarivanja,DatumPosljednjeDonacije,Hemoglobin,KrvniPritisak,Pol,StatusDonora,ZdravstvenaHistorijaId")] Donor donor)
        {
            if (id != donor.DonorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(donor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DonorExists(donor.DonorId))
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
            return View(donor);
        }

        // GET: Donor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var donor = await _context.Donor
                .FirstOrDefaultAsync(m => m.DonorId == id);
            if (donor == null)
            {
                return NotFound();
            }

            return View(donor);
        }

        // POST: Donor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var donor = await _context.Donor.FindAsync(id);
            _context.Donor.Remove(donor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DonorExists(int id)
        {
            return _context.Donor.Any(e => e.DonorId == id);
        }

        private string GenerisiUsername(string ime, string prezime)
        {
            string username;

            if(prezime.Length > 8)
            {
                username = ime.Substring(0, 1).ToLower() + prezime.Substring(0,7).ToLower();
            } else
            {
                username = ime.Substring(0, 1).ToLower() + prezime.ToLower();
            }
            

            StringBuilder builder = new StringBuilder(username);

            for(int i=0; i<builder.Length; i++)
            {
                if(builder[i] == 'č' || builder[i] == 'ć')
                {
                    builder[i] = 'c';
                } else if (builder[i] == 'đ')
                {
                    builder[i] = 'd';
                } else if (builder[i] == 'š')
                {
                    builder[i] = 's';
                } else if (builder[i] == 'ž')
                {
                    builder[i] = 'z';
                }
            }

            username = builder.ToString();
            int dodatak = 1;

            while(ProvjeriUsername(username))
            {
                username = username + (dodatak++).ToString();
            }

            return username;
        }

        private bool ProvjeriUsername(string username)
        {
            List<Donor> donori = _context.Donor.ToList();

            foreach(var donor in donori)
            {
                if (donor.Username.Equals(username)) return true;
            }
            return false;
        }
    public async Task<IActionResult> PregledObavijesti(int? id)
    {
        if(id == null)
        {
            return NotFound(); 
        }
       
            var obavijesti = _context.ObavijestDonor.AsQueryable();
            

            
                obavijesti = obavijesti.Where(obavijest => obavijest.DonorId == id);
            

            return View(await obavijesti.ToListAsync());
        }
    }

}
