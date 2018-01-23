using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AldiScheduleMaker.Models;


namespace AldiScheduleMaker.Controllers
{
    public class ScheduleController
    {
        private Aldi_EmployeesEntities ORM = new Aldi_EmployeesEntities();

        public List<Employee> GetAllEmployees()
        {
            List<Employee> EmployeeList = ORM.Employees.ToList();
            return EmployeeList;
        }
    }
}