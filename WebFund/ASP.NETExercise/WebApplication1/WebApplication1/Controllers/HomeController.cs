using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            ViewBag.Message = "Hello World!";
            ViewData["Mes"] = "Nice to see you working!!!";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Message = "This is the ASP.NET Core MVC app!";
            return View();
        }

        public IActionResult Numbers()
        {
            return View();
        }

        public IActionResult NumbersToN(int counter = 0)
        {
            ViewData["Count"] = counter;
            return View();
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