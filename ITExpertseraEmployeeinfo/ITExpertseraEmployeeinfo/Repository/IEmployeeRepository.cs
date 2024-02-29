using ITExpertseraEmployeeinfo.Models;

namespace ITExpertseraEmployeeinfo.Repository
{
    public interface IEmployeeRepository
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployeebyid(int id);
        public void upDateEmployee(Employee employee);
        public void deleteEmployee(int id);
    }
}
