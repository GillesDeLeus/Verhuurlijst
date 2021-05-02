using Guns.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Guns.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        static int aantalKogels = 0;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.aantalKogels = aantalKogels;
            ViewBag.randomNumber = 0;
            return View();
        }
        public IActionResult Schiet() {
            if (aantalKogels > 0)
            {
                int kg = aantalKogels - 1;
                aantalKogels = kg;
                ViewBag.aantalkogels = kg;
                Random random = new Random();
                int randomNumber = random.Next(0, 10);
                ViewBag.randomNumber = randomNumber;
                if (randomNumber < 4)
                {
                    return View("Winnaar");
                }
                else
                {
                    return View("Index");
                }
            }
            else {
                return View("Reload");
            }
        }

        public IActionResult Homepage() {
            ViewBag.aantalKogels = aantalKogels;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Winnaar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Winnaar(Persoon persoon)
        {
            if (ModelState.IsValid)
            {
                DateTime hour = DateTime.Now;
                ViewBag.Tijd = hour;
                return View("Samenvatting", persoon);
            }
            else
            {
                return View("Winnaar");
            }
        }

        public IActionResult Reload1() {
            int kg = aantalKogels + 2;
            aantalKogels = kg;
            ViewBag.aantalkogels = kg;
            return View("Index");
        }
        public IActionResult Reload2()
        {
            int kg = aantalKogels + 7;
            aantalKogels = kg;
            ViewBag.aantalkogels = kg;
            return View("Index");
        }
        public IActionResult Reload3()
        {
            int kg = aantalKogels + 12;
            aantalKogels = kg;
            ViewBag.aantalkogels = kg;
            return View("Index");
        }
    }
}
