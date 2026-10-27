using SampleForHandsOnExp_MVC_WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleForHandsOnExp_MVC_WebApplication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details(int id)
        {
           // Sample.
            Employee emp = new Employee() { EmployeeId = 1, DeptId = 2, EmployeeName = "Sri", Salary = 100};
            //DbContext
            EmployeeContext employeeContext = new EmployeeContext();
            emp = employeeContext.Employees.Single(x => x.EmployeeId == id);
            return View(emp);
        }

        public ActionResult Index(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();

            return View(employeeContext.Employees.Where(x => x.DeptId == id));
        }
    }
}