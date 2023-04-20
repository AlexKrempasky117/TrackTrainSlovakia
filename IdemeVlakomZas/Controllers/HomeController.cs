using IdemeVlakomZas.Data;
using IdemeVlakomZas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdemeVlakomZas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContent _db;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContent db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<Trains> VlakySVK = _db.VlakySVK.ToList(); 
            return View(VlakySVK);
        }

        public IActionResult Privacy()
        {
            IEnumerable<Trains> VlakySVK = _db.VlakySVK.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}