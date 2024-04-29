using Microsoft.AspNetCore.Mvc;
using MvcCoreDeployment.Models;
using System.Diagnostics;

namespace MvcCoreDeployment.Controllers
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
            ViewData["Saludo"] = " Nuestra app Deployment en Github";
            Random ran = new Random();
            List<int> numeros = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                int numero = ran.Next(1, 50);
                numeros.Add(numero);
            }
            return View(numeros);
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
