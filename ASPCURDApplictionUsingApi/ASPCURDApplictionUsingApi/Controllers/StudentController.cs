using ASPCURDApplictionUsingApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ASPCURDApplictionUsingApi.Controllers
{
    public class StudentController : Controller
    {
        private string URL = "https://localhost:7094/api/StudentsApi";
        private HttpClient client = new HttpClient();
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            HttpResponseMessage response = client.GetAsync(URL).Result;
            if (response.IsSuccessStatusCode) 
            {
                string result = response.Content.ReadAsStringAsync().Result;
                var data = JsonConvert.DeserializeObject<List<Student>>(result);
                if (data != null)
                {
                    students = data;
                }
            }
            return View(students);
        }
    }
}
