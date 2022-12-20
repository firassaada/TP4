using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.Models.Data;

namespace WebApplication4.Controllers
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
            UniversityContext first = UniversityContext.Instantiate_universityContext();
            Debug.WriteLine("Selemoou aalaykom" +UniversityContext.count);
            return View(first);
        }

        public IActionResult Privacy()
        {
            UniversityContext first = UniversityContext.Instantiate_universityContext() ;
            Debug.WriteLine("Selemoou aalaykom" + UniversityContext.count);
            return View(first);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}