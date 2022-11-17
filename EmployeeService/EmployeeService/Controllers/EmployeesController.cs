using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeDataAccess;


namespace EmployeeService.Controllers
{
    public class EmployeesController : ApiController
    {
        public IEnumerable<employee> Get()
        {
            using (employeeDBEntities entities = new employeeDBEntities())
            {
                return entities.employees.ToList();
            }
        }

        public employee Get(int id)
        {
            using (employeeDBEntities entities = new employeeDBEntities())
            {
                return entities.employees.FirstOrDefault(e => e.emp_id == id);
            }
        }
    }
}
