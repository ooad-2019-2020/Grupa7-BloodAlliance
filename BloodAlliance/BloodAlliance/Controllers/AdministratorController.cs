using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BloodAlliance.Controllers
{
    
    public class AdministratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}