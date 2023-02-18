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
            var db = new DOTNETEntities2();
            db.People.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var db = new DOTNETEntities2();
            var peoples=db.People.ToList();
            return View(peoples);
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