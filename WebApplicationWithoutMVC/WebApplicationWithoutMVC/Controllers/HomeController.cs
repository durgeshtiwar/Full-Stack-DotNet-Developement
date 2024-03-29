using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWithoutMVC.Controllers
{
    [Route("[Controller]/[Action]")]
    public class HomeController : Controller
    {
        
        //[Route("~/")]
        //[Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [Route("{id?}")]
        public int Details(int ? id)
        {

            return id ?? 1;
        }
    }
}
