using CreatingLoginForm.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace CreatingLoginForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly CodeFirstDbContext context;

        public HomeController(CodeFirstDbContext _context)
        {
            this.context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("MySession") != null)
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Login(Employee emp)
        {
            var myUser = context.Employees.Where(x => x.Email == emp.Email && x.Password == emp.Password).FirstOrDefault();
            if (myUser != null)
            {
                HttpContext.Session.SetString("MySession",myUser.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                ViewBag.Message = "Login Failed..";
            }
            return View();
        }
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("MySession")!=null)
            {
                ViewBag.userMessage = HttpContext.Session.GetString("MySession").ToString();
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("MySession") != null)
            {
                HttpContext.Session.Remove("MySession");
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(Employee emp)
        {
            if (ModelState.IsValid)
            {
                await context.Employees.AddAsync(emp);
                await context.SaveChangesAsync();
                TempData["Register"] = "Registered Successfully";
                return RedirectToAction("Login");
            }
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
