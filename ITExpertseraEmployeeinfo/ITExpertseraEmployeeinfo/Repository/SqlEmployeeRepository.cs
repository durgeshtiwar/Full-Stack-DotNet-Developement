using ITExpertseraEmployeeinfo.Data;
using ITExpertseraEmployeeinfo.Models;

namespace ITExpertseraEmployeeinfo.Repository
{
    public class SqlEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public SqlEmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void createEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void deleteEmployee(int id)
        {
            Employee employee = _context.Employees.First(item => item.id == id);
            _context.Remove(employee);
            _context.SaveChanges();
        }

        public Employee GetEmployeebyid(int id)
        {
            //Use linq quary

            Employee employee = _context.Employees.First(item => item.id == id);
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        public void upDateEmployee(Employee employee)
        {
            Employee emp = _context.Employees.First(item => item.id == employee.id);
            emp.name = employee.name;
            emp.salary = employee.salary;
            emp.city = employee.city;

            _context.Employees.Update(emp);
            _context.SaveChanges(); 
        }
    }
}
