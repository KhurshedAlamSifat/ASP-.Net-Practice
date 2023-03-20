using MidAssignment.EF;
using MidAssignment.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
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

        public ActionResult SeeReq()
        {
            if (Session["request"] != null)
                return View((List<Restaurant>)Session["request"]);
            TempData["Msg"] = "No request";
            TempData["Color"] = "alert-info";
            return RedirectToAction("Dashboard");
        }
        public ActionResult Place()
        {
           
            var restaurant = (List<Restaurant>)Session["request"];

            foreach (var item in restaurant)
            {
                RestaurantEmployee od = new RestaurantEmployee();
                od.EmployeeId = 1;
                od.RestaurantId = 1;
                db.RestaurantEmployees.Add(od);
            }
            db.SaveChanges();
            Session["cart"] = null;
            TempData["Msg"] = "Collect request accepted";
            TempData["Color"] = "alert-success";
            return RedirectToAction("Dashboard");

        }
        public ActionResult EmployeeProfile(int id)
        {
            var restaurant = (from s in db.Employees
                              where s.Id == id
                              select s).SingleOrDefault();
            return View(restaurant);
        }
        public ActionResult WorkHistory(int id)
        {
            var st = (from s in db.RestaurantEmployees
                      from s2 in db.Restaurants
                      where s.EmployeeId == id && s2.Id == s.RestaurantId
                      select s2).ToList();
            return View(st);
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}