using AronGibsonDeckOfCardsAPILab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AronGibsonDeckOfCardsAPILab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DeckDAL deckDAL = new DeckDAL();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DeckModel result = deckDAL.GetData();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Reshuffle()
        {
            DeckModel result = deckDAL.ShuffleCards();
            return View(result);
        }

        public IActionResult DeckResult()
        {
            DeckModel result = deckDAL.GetData();
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
