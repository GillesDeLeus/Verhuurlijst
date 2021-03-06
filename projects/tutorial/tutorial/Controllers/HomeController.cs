using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using tutorial.Models;

namespace tutorial.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult RsvpForm() {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(GeustResponse geustResponse) {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(geustResponse);
                return View("thanks", geustResponse);
            }
            else {
                return View();
            }
        }

        public IActionResult ListResponses() {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
