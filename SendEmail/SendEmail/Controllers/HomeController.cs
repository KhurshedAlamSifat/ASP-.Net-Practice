using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace SendEmail.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { return View(); }
        [HttpPost]
        public ActionResult Index(string useremail)
        {
            string subject = "Welcome in MOlla's Fuel!";
            string body = "Hello Mr." +
                "We would love to welcome you in Our Mollas Fuel." +
                "Thanks for Sign UP!";
            WebMail.Send(useremail, subject, body, null, null, null, true, null, null, null, null, null, null);
            ViewBag.Msg = "Email Send Successfully!";
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
    }
}