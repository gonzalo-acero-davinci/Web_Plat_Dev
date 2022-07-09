using Microsoft.AspNetCore.Mvc;
using Página_Web_Plat_Dev.Models;
using System.Diagnostics;

namespace Página_Web_Plat_Dev.Controllers
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

        /*public IActionResult vistaRegistro()
        {
            return View();
        }*/
        
        public IActionResult TutorialDeUso()
        {
            return View();
        }

        public IActionResult Descarga() 
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