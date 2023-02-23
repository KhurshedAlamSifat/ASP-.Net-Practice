using EntityFramwork.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls.WebParts;

namespace EntityFramwork.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person model) 
        {
            var db = new DOTNETEntities3();
            db.People.Add(model);   
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var db = new DOTNETEntities3();
            var peoples=db.People.ToList();
            return View(peoples);
        }
        public ActionResult Details(int id)
        {
            var db = new DOTNETEntities3();
            var st = (from s in db.People
                      where s.id == id
                      select s).SingleOrDefault();
            return View(st);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new DOTNETEntities3();
            var st = (from s in db.People
                      where s.id == id
                      select s).SingleOrDefault();
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(Person model)
        {
            var db = new DOTNETEntities3();
            var exst = (from s in db.People
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