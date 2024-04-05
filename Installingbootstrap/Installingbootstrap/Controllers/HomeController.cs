using Microsoft.AspNetCore.Mvc;

namespace Installingbootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
