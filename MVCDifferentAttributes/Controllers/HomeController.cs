using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDifferentAttributes.Models;
using System.Data;

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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            EmployeeEntities db = new EmployeeEntities();
            Employee employeeFromDB = db.Employees.Single(x => x.Id == id);

            return View(employeeFromDB);
        }

        public ActionResult TemplateExamples(int id)
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            Employee employee = employeeEntities.Employees.Single(x => x.Id == id);
            //ViewData["EmployeeData"] = employee;
            return View(employee);
        }
    }
}