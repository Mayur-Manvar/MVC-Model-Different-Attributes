using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDifferentAttributes.Models;

namespace MVCDifferentAttributes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id)
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            Employee employee = employeeEntities.Employees.Single(x => x.Id == id);
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeEntities db = new EmployeeEntities();
                Employee employeeFromDB = db.Employees.Single(x => x.Id == employee.Id);

                // Populate all the properties except EmailAddrees
                employeeFromDB.FullName = employee.FullName;
                employeeFromDB.Gender = employee.Gender;
                employeeFromDB.Age = employee.Age;
                employeeFromDB.HireDate = employee.HireDate;
                employeeFromDB.Salary = employee.Salary;
                employeeFromDB.PersonalWebSite = employee.PersonalWebSite;

                db.ObjectStateManager.ChangeObjectState(employeeFromDB, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Details", new { id = employee.Id });
            }
            return View(employee);
        }
    }
}