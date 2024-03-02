using ITExpertseraEmployeeinfo.Models;
using ITExpertseraEmployeeinfo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITExpertseraEmployeeinfo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository;
        public EmployeeController()
        {
            _employeeRepository = new EmployeeRepository();
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            List<Employee> _employeeList = _employeeRepository.GetEmployees();
            return View(_employeeList);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var Employee = _employeeRepository.GetEmployeebyid(id);
            return View(Employee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee collection)
        {
            try
            {
                _employeeRepository.createEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var Employee = _employeeRepository.GetEmployeebyid(id);
            return View(Employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee collection)
        {
            try
            {
                _employeeRepository.upDateEmployee(collection);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var Empolyee = _employeeRepository.GetEmployeebyid(id); 
            return View();
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee collection)
        {
            try
            {
                _employeeRepository.deleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
