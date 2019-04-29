using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here's a little about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This doesn't exist any more";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "My Previous Projects.";

            return View();
        }

        public ActionResult Skills()
        {
            ViewBag.Message = "Here are my skills.";

            return View();
        }
    }
}