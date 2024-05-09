using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsApiController : ControllerBase
    {
        public List<string> fruits = new List<string>()
        {
            "Mango",
            "Banana",
            "Grapes",
            "Watermelon",
            "Apple",
            "Orange",
        };
        [HttpGet]
        public List<string> getFruite() 
        { 
            return fruits;
        }
        [HttpGet("{id}")]
        public string getFruitebyId(int id)
        {
            return fruits.ElementAt(id);
        }
    }
}
