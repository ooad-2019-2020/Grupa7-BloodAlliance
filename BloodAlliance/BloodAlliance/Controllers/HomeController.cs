using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BloodAlliance.Models;
using Microsoft.AspNetCore.Identity;
using static BloodAlliance.Areas.Identity.Pages.Account.LoginModel;

namespace BloodAlliance.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly BAContext _context;

        public HomeController(BAContext context, ILogger<HomeController> logger, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }

        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if(result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    var roles = await _userManager.GetRolesAsync(user);
        
                    foreach(var role in roles)
                    {
                        if(role == "Donor")
                        {
                            return RedirectToAction("Index", "Donor");
                        } else if (role == "Administrator")
                        {
                            return RedirectToAction("Index", "Donacija");
                        } else if (role == "Bolnica")
                        {
                            return RedirectToAction("Index", "Bolnica");
                        }
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            return View(model);
        }

        
    }
}
