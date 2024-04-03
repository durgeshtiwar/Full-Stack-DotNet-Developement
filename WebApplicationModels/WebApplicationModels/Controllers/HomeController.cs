using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationModels.Models;
//using WebApplicationModels.Repository;

namespace WebApplicationModels.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly IStudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //_studentRepository = new StudentRepository();
        }
        //public List<StudentModel> getAllStudent()
        //{
        //    return _studentRepository.getAllStudent();
        //} 
        //public StudentModel getById(int id)
        //{
        //    return _studentRepository.GetStudentById(id);
        //}

        public IActionResult Index()
        {
            var student = new List<StudentModel>
            {
            new StudentModel {rollNo = 1, name = "Durgesh Tiawri",gender ="Male",standard = 10 },
            new StudentModel { rollNo = 2, name = "Aditya Tiawri", gender = "Male", standard = 15 },
            new StudentModel { rollNo = 3, name = "Shubham Tiawri", gender = "Male", standard = 12 },
            new StudentModel { rollNo = 4, name = "Roli Tiawri", gender = "Female", standard = 10 },
            };
            //ViewData["myStudent"] = student;
            ViewBag.myStudent = student;
            //TempData["OnylStudent"] = student;
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
