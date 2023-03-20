using MidAssignment.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MidAssignment.Controllers
{
    public class RestaurantController : Controller
    {
        NGO db = new NGO();
        // GET: Restaurant
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult RestaurantProfile(int id) 
        {
            var restaurant = (from s in db.Restaurants
                              where s.Id == id 
                              select s).SingleOrDefault();
            return View(restaurant);
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}