using BindMultipleModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindMultipleModel.Controllers
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
            List<Student> students = new List<Student>
            {
                new Student { Id=1, name="Durgesh Tiwari", gender="Male", standard=12},
                new Student { Id=2, name="Shubham Tiwari", gender="Male", standard=11},
                new Student { Id=3, name="Aditya Tiwari", gender="Male", standard=10},
                new Student { Id=4, name="Bintu Tiwari", gender="Female", standard=9}
            };
            List<Teacher> teachers = new List<Teacher>
            {
                new Teacher { Id=1, name="Anil Pandey", qualication="Ms.c", gender="Male"},
                new Teacher { Id=2, name="OmShakti Tiwari", qualication="Ms.c", gender="Male"},
                new Teacher { Id=3, name="Ram Kishan Shukla", qualication="Ms.c", gender="Male"},
                new Teacher { Id=4, name="Priya Shukla", qualication="M.A.", gender="Female"}
            };
            SchoolViewModel svm = new SchoolViewModel { Students = students, Teachers = teachers };
            return View(svm);
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
