using BindDDLwithDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindDDLwithDatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext context;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(CodeFirstDbContext context)
        {
            this.context = context;
        }



        public IActionResult Index()
        {
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
