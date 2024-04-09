using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TagHelperDemo.Models;

namespace TagHelperDemo.Controllers
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

        [HttpPost]
        public string Index(Employee emp)
        {
            return "Name : " + emp.name + "Age : " + emp.age + "Gender : " + emp.Gender +"Designation : " + emp.designation + "Sallary : " + emp.sallary+"Married : " + emp.married+"Description : " + emp.description;
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
