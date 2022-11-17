using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeService.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDataAccess.employeeDBEntities db = new EmployeeDataAccess.employeeDBEntities();
        public ActionResult Index(string searching)
        {
            var result = db.employees.Where(x => x.emp_name.Contains(searching) || searching == null).ToList();
            return View(result);
        }
    }
}
