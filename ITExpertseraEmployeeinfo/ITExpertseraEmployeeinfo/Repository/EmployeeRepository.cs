using ITExpertseraEmployeeinfo.Models;

namespace ITExpertseraEmployeeinfo.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees = new List<Employee>();
        public EmployeeRepository() 
        {
            Employee objEmployee1 = new Employee();
            objEmployee1.id = 1;
            objEmployee1.name = "Durgesh Tiwari";
            objEmployee1.city = "Ayodhya";
            objEmployee1.salary = 5000;

            _employees.Add(objEmployee1);

            _employees.Add(new Employee() { id = 2, name = "Aditya Singh", city = "Barabanki", salary = 7000 });
            _employees.Add(new Employee() { id = 3, name = "Kisalay Singh", city = "Azamgharh", salary = 8000 });
            _employees.Add(new Employee() { id = 4, name = "Shivam Yadav", city = "Prayagraj", salary = 9000 });
        }
        public void deleteEmployee(int id)
        {
            Employee employee = _employees.First(item => item.id == id);
            _employees.Remove(employee);
        }

        public Employee GetEmployeebyid(int id)
        {
            //Use linq quary

            Employee employee = _employees.First(item => item.id == id);
            return employee;
           
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void upDateEmployee(Employee employee)
        {
            Employee emp = _employees.First(item => item.id == employee.id);
            emp.name = employee.name;
            emp.salary = employee.salary;
            emp.city = employee.city;

        }
    }
}
