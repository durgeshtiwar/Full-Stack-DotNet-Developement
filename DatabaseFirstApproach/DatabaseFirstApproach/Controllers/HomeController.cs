using DatabaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DatabaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CodeFirstDbContext _contex;

        public HomeController(ILogger<HomeController> logger,CodeFirstDbContext _contex)
        {
            _logger = logger;
            this._contex = _contex;
        }

        public IActionResult Index()
        {
            var studentData = _contex.Students.ToList();
            return View(studentData);
        }
        public IActionResult Details(int? id)
        {
            var studentData = _contex.Students.FirstOrDefault(x => x.Id == id);
            return View(studentData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            if (ModelState.IsValid)
            {
                var studentData = _contex.Students.Add(std);
                _contex.SaveChanges();
                
            }
            return RedirectToAction("Index", "Home");
            //return View();
        }
        public IActionResult Edit(int? id)
        {
            if (id == null||_contex.Students == null)
            {
                return NotFound();
            }
            var studentData = _contex.Students.Find(id);
            if (studentData == null)
            {
                return NotFound();
            }
            return View(studentData);
        }
        [HttpPost]
        public IActionResult Edit(int? id , Student std)
        {
            if (std.Id != id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var studentData = _contex.Students.Update(std);
                _contex.SaveChanges();
                
            }
            return RedirectToAction("Index", "Home");
            //return View();
        }
        public IActionResult Delete(int ? id)
        {
            if (id == null || _contex.Students == null)
            {
                return NotFound();
            }
            var studentData = _contex.Students.FirstOrDefault(x=>x.Id == id);
            if (studentData == null)
            {
                return NotFound();
            }
            return View(studentData);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            var studentData = _contex.Students.Find(id);
            if (studentData != null)
            {
                _contex.Students.Remove(studentData);
            }
            _contex.SaveChanges();
            return RedirectToAction("Index", "Home");
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
