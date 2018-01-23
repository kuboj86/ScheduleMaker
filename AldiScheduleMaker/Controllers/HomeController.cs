using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

using System.Web.DynamicData;

using AldiScheduleMaker.Models;
using System.Data.Entity;

namespace AldiScheduleMaker.Controllers
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

        public ActionResult ShowSchedule()
        {
            ScheduleController DAL = new ScheduleController();

            ViewBag.EmployeeList = DAL.GetAllEmployees();
            return View("ShowSchedule");
        }
    }
}