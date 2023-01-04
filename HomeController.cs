using FahrenaytWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FahrenaytWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Fahrenayt fahrenayt)
        {
            //cshtml deki 
            var fDerece = fahrenayt.FahrenaytDerecesi;
            var message = string.Empty;
            var formula = ((fDerece-32)*5) / 9;


            ViewBag.Message = formula;
            return View("fahrenayt");
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