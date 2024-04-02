using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWithoutMVC.Controllers
{
    [Route("[Controller]/[Action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            //ViewData["Data1"] = "Computer Science And Engineering";
            //ViewData["Data2"] = 20;
            //ViewData["Data3"] = DateTime.Now.ToLongDateString();
            //string[] arr = {"Durgesh","Aditya","Kisalay","Shivam"};
            //ViewData["Data4"] = arr;
            //ViewData["Data5"] = new List<string>()
            //{
            //    "Cricket","Football","Hockey"
            //};



            //ViewData["Data1"] = "Computer Science And Engineering";
            //ViewBag.Data2 = 20;
            //ViewBag.Data3 = DateTime.Now.ToLongDateString();
            //string[] arr = { "Durgesh", "Aditya", "Kisalay", "Shivam" };
            //ViewBag.Data4 = arr;
            //ViewBag.Data5 = new List<string>()
            //{
            //    "Cricket","Football","Hockey"
            //};


            TempData["Data1"] = "Computer Science And Engineering";
            TempData["Data2"] = 25;
            TempData["Data3"] = DateTime.Now.ToLongDateString();
            TempData["Data4"] = new List<string>()
            {
                "Cricket","Football","Hockey"
            };
            TempData.Keep();

            return View();
        }
        public IActionResult About()
        {
            TempData.Keep();
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep();
            return View();
        }
        [Route("{id?}")]
        public int Details(int ? id)
        {

            return id ?? 1;
        }
    }
}
