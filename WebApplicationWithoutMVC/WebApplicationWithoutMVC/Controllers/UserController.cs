using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWithoutMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
