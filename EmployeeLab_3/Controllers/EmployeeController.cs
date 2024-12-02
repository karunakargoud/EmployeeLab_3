using EmployeeLab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeLab_3.Controllers
{
    public class EmployeeController : Controller
    {
       public ActionResult EnterNewEmployeeDetails()
        {
            return View();
        }
        public ActionResult SaveEmployeeDetails()
        {
            Employee e = new Employee();
            e.EmployeeId = int.Parse(Request.Form["EmployeeId"]);
            e.EmployeeName = Request.Form["EmployeeName"];
            e.Designation = Request.Form["Designation"];
            e.age = Request.Form["age"];
            e.Salary = int.Parse(Request.Form["Salary"]);

            return View("DisplayEmployeeDetails",e);
        }
    }
}