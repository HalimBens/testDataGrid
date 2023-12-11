using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testDataGrid.Models;

namespace testDataGrid.Controllers
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
            List<Pays> listePays = new List<Pays>()
            {
                new Pays() { Id = 1, Nom = "Canada"},
                new Pays() { Id = 2, Nom = "France"},
                new Pays() { Id = 3, Nom = "Algérie"},
                new Pays() { Id = 4, Nom = "Espagne"},
                new Pays() { Id = 5, Nom = "Royaume Unis"}
            };

            List<Ville> listeVille = new List<Ville>()
            {
                new Ville() { Id = 1, Nom = "Madrid", Pays = listePays.ElementAt(3) },
                new Ville() { Id = 2, Nom = "Paris", Pays = listePays.ElementAt(1) },
                new Ville() { Id = 3, Nom = "Alger", Pays = listePays.ElementAt(2) },
                new Ville() { Id = 4, Nom = "Montréal", Pays = listePays.ElementAt(0) },
                new Ville() { Id = 5, Nom = "Laval", Pays = listePays.ElementAt(0) },
                new Ville() { Id = 6, Nom = "Londre", Pays = listePays.ElementAt(4) }
            };

            return View(listeVille);
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