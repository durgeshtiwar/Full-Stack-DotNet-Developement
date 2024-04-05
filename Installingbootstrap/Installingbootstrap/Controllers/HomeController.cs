using Installingbootstrap.Models;
using Microsoft.AspNetCore.Mvc;

namespace Installingbootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>()
            {
                new Student{id= 1,name= "Durgesh Tiwari",gender = "Male"},
                new Student{id= 2,name= "Shubham Tiwari",gender = "Male"},
                new Student{id= 3,name= "Aditya Tiwari",gender = "Male"},
            };
            return View(student);
        }
        public IActionResult About()
        {
            var student = new List<Student>()
            {
                new Student{id= 1,name= "Durgesh Tiwari",gender = "Male"},
                new Student{id= 2,name= "Shubham Tiwari",gender = "Male"},
                new Student{id= 3,name= "Aditya Tiwari",gender = "Male"},
            };
            return View(student);
        }
        public IActionResult Contact()
        {
            var student = new List<Student>()
            {
                new Student{id= 1,name= "Durgesh Tiwari",gender = "Male"},
                new Student{id= 2,name= "Shubham Tiwari",gender = "Male"},
                new Student{id= 3,name= "Aditya Tiwari",gender = "Male"},
            };
            return View(student);
        }
    }
}
