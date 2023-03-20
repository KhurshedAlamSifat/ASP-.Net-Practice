using MidAssignment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidAssignment.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        NGO db = new NGO();
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult EmployeeProfile(int id)
        {
            var restaurant = (from s in db.Employees
                              where s.Id == id
                              select s).SingleOrDefault();
            return View(restaurant);
        }
        public ActionResult WorkHistory()
        { 
            return View(); 
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}