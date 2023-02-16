using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}