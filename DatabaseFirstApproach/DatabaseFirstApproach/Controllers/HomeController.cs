using DatabaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CodeFirstDbContext std;

        public HomeController(ILogger<HomeController> logger,CodeFirstDbContext std)
        {
            _logger = logger;
            this.std = std;
        }

        public IActionResult Index()
        {
            var studentData = std.Students.ToList();
            return View(studentData);
        }
        public IActionResult Details(int id)
        {
            var studentData = std.Students.FirstOrDefault(x => x.Id == id);
            return View(studentData);
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
