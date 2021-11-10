using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee() { empid = 123, ename = "Swati", location = "Pune" };
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){empid=111,ename="Aniket",location="Pune"},
                new Employee(){empid=112,ename="Nishant",location="Mumbai"},
                new Employee(){empid=113,ename="Omkar",location="Chennai"}
            };
            ViewData["employee"] = e;
            ViewBag.emp = e;
            return View(employees);
        }
        public string AboutUs()
        {
            return "This is about us page";
        }
    }
}