using BindDDLwithDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        private StudentModel BDDList()
        {
            StudentModel stdModel = new StudentModel();
            stdModel.studentList = new List<SelectListItem>();
            var data = context.Students.ToList();
            stdModel.studentList.Add(new SelectListItem
            {
                Text = "Select Name",
                Value = ""
            });
            foreach (var item in data)
            {
                stdModel.studentList.Add(new SelectListItem
                {
                    Text = item.StudentName,
                    Value = item.Id.ToString()
                });
            }
            return (stdModel);
        }
        public IActionResult Index()
        {
            var stdmodel = BDDList();
            return View(stdmodel);
        }
        [HttpPost]
        public IActionResult Index(StudentModel std)
        {
            var student = context.Students.Where(x => x.Id == std.Id).FirstOrDefault();
            if(student!=null)
            {
                ViewBag.selectStudent = student.StudentName;
            }
            var stdmodel = BDDList();
            return View(stdmodel);
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
