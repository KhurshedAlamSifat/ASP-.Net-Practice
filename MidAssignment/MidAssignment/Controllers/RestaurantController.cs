using Microsoft.Win32;
using MidAssignment.EF;
using MidAssignment.EF.Models;
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
        public ActionResult CollectRequest(int id)
        {
            var restaurant = db.Restaurants.Find(id);

            List<Restaurant> request = null;
            if (Session["request"] == null)
            {
                request = new List<Restaurant>();
            }
            else
            {
                request = (List<Restaurant>)Session["request"];
            }

            request.Add(new Restaurant()
            {
                Id = restaurant.Id,
                Name = restaurant.Name,
                Time="12:30AM",
            });
            db.SaveChanges();
            Session["request"] = request;
            TempData["Msg"] = "Successfully send collect request";
            TempData["Color"] = "alert-success";
            return RedirectToAction("Dashboard");
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