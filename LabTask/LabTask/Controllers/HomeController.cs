using LabTask.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User model)
        {
            var db = new TASKEntities2();
            db.Users.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var db = new TASKEntities2();
            var users = db.Users.ToList();
            return View(users);
        }
        public ActionResult Order(int id)
        {
            var db = new TASKEntities2();
            var st = (from s in db.UserOrders
                      from s2 in db.Orders
                      where s.u_id == id && s2.id == s.o_id
                      select s2).SingleOrDefault();
            return View(st);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new TASKEntities2();
            var st = (from s in db.Users
                      where s.id == id
                      select s).SingleOrDefault();
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(User model)
        {
            var db = new TASKEntities2();
            var exst = (from s in db.Users
                        where s.id == model.id
                        select s).SingleOrDefault();
            /*exst.Name = model.Name;
            exst.Profession = model.Profession;
            exst.Gender = model.Gender;
            exst.Dob = model.Dob;*/
            db.Entry(exst).CurrentValues.SetValues(model);
            //db.Students.Remove(exst);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Product(int id)
        {
            var db = new TASKEntities2();
            var st = (from s in db.Products
                      from s2 in db.OrderProducts
                      where s2.o_id == id && s.id == s2.p_id
                      select s).SingleOrDefault();
            return View(st);
        }
        /*public ActionResult Delete(int id)
        {
            var db = new TASKEntities2();
            var st = (from s in db.Orders
                      where s.id == id
                      select s).SingleOrDefault();
            db.Orders.Remove(st);
            db.SaveChanges();
            return RedirectToAction("List");
        }*/

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
    }
}