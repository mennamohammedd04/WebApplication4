using Microsoft.AspNetCore.Mvc;
using WebApplication4.DAL.database;
using WebApplication4.DAL.entities;

namespace WebApplication4.Controllers
{
    public class Employeecontroller : Controller
    {
        applicationdbcontext Db = new applicationdbcontext();

        public IActionResult Index()
        {
            var result = Db.Employees.ToList();
            ViewBag.GetAllEmployee = result;

            return View(result);

        }
        [HttpGet]
        public IActionResult create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult create(string name , int age )
        {
            Employee emp = new Employee();
            emp.Name = name;
            emp.age = age;
            Db.Employees.Add(emp);
            Db.SaveChanges();
            return RedirectToAction("index", "Employee");
    
            return View();

        }
        [HttpGet]
        public IActionResult edit()
        {
            var data = Db.Employees.Where(a => a.Id== 1).FirstOrDefault();
            return View(data);

        }
        [HttpPost]
        public IActionResult edit(string name, int age, int id)
        {

            var data = Db.Employees.Where(a => a.Id == 1).FirstOrDefault();
            data.Name = name;
            data.age = age;
           
            Db.SaveChanges();
            return RedirectToAction("index", "Employee");

            return View();

        }
    }
}
