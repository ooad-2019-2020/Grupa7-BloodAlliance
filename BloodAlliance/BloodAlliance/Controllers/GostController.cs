using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BloodAlliance.Controllers
{
    public class GostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Test ()
        {

            return View();
        }

        public IActionResult Informacije ()
        {
            return View();
        }
    }
}