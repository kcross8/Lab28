using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _601WebAPI_Intro.Models;

namespace _601WebAPI_Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SwapiDAL SP = new SwapiDAL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Person p = SP.GetPerson("people", 3);
            Planet c = SP.GetPlanet("planets", 3);
            Starship s = SP.GetStarship("starships", 3);
            return View(c);
        }

        public IActionResult PersonSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PersonSearch(int Id)
        {
            //we want to use the DAL to search people by Id 
            Person p = SP.GetPerson("people", Id);
            return View(p);
        }
        public IActionResult PlanetSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PlanetSearch(int Id)
        {
            Planet p = SP.GetPlanet("planets", Id);
            return View(p);
        }
        public IActionResult StarshipSearch()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StarshipSearch(int Id)
        {
            Starship s = SP.GetStarship("starships", Id);
            return View(s);
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
    }
}
