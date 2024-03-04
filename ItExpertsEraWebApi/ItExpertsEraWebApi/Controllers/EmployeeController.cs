using ItExpertsEraWebApi.Entity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ItExpertsEraWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> _employees = new List<Employee>();
        static EmployeeController()
        {
            _employees.Add(new Employee() { EnployeeId = 1,EmployeeName = "Durgesh Tiawri",DepartmentName="Computer Science"});
            _employees.Add(new Employee() { EnployeeId = 2, EmployeeName = "Aditya Singh", DepartmentName = "Information Technology" });
            _employees.Add(new Employee() { EnployeeId = 3, EmployeeName = "Kiaslay Singh", DepartmentName = "Civil" });
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            var employee = _employees.FirstOrDefault(Value=>Value.EnployeeId == id);
            return employee;
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public void Post([FromBody] Employee value)
        {
            _employees.Add(value);
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Employee value)
        {
            var employee = _employees.FirstOrDefault(item => item.EnployeeId == id);
            employee.EmployeeName = value.EmployeeName;
            employee.DepartmentName = value.DepartmentName;
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var employee = _employees.FirstOrDefault(item => item.EnployeeId == id);
            _employees.Remove(employee);
        }
    }
}
