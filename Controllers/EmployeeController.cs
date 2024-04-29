using EntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameWork.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _emp;
        public EmployeeController(EmployeeDbContext emp) {
            _emp = emp;
        }
        public IActionResult Index()
        {
            var em = _emp.Employees.ToList();
            return View(em);
        }

        //Add employee
        public IActionResult AddEmp()

        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddEmp(Employee emp)

        {
            _emp.Employees.Add(emp);
            _emp.SaveChanges();
            return View();
        }

        [HttpPost]
        public IActionResult Del(int id)
        {
            var emp = _emp.Employees.Find(id);
            _emp.Employees.Remove(emp);
            _emp.SaveChanges();
           return RedirectToAction ("Index");
           

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var emp = _emp.Employees.Find(id);
           
            return View(emp);

        }
        [HttpPost]
        public IActionResult Edit(Employee emp) {
            _emp.Employees.Update(emp);
            _emp.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
