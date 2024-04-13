using CodeFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext studentDb;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(StudentDbContext studentDb)
        {
            this.studentDb = studentDb;
        }

        public async Task<IActionResult> Index()
        {
            var studentData = await studentDb.Students.ToListAsync();
            return View(studentData);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student std)
        {
            if (ModelState.IsValid)
            {
                await studentDb.Students.AddAsync(std);
                await studentDb.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public async Task<IActionResult> Details(int? Id)
        {
            if (Id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var studentData = await studentDb.Students.FirstOrDefaultAsync(x => x.id == Id);
            if (studentData == null)
            {
                return NotFound();
            }
            return View(studentData);
        }
        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var studentData = await studentDb.Students.FindAsync(Id);
            if (studentData == null)
            {
                return NotFound();
            }
            return View(studentData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(int? Id, Student std)
        {
            if (std.id != Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                //studentDb.Students.Update(std); Or
                studentDb.Update(std);
                await studentDb.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public async Task<IActionResult> Delete(int? Id)
        {
            if (Id == null || studentDb.Students == null)
            {
                return NotFound();
            }
            var studentData = await studentDb.Students.FirstOrDefaultAsync(x => x.id == Id);
            if (studentData == null)
            {
                return NotFound();
            }
            return View(studentData);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(int? Id)
        {
            var studentData = await studentDb.Students.FindAsync(Id);
            if (studentData != null)
            {
                studentDb.Students.Remove(studentData);
            }
            await studentDb.SaveChangesAsync();
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
