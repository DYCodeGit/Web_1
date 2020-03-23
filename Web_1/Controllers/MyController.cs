using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_1.Controllers
{
    public class MyController : Controller
    {
        public ActionResult Cat()
        {

            return View();
        }

        public ActionResult Dog()
        {

            return View();
        }

        [HttpGet()]
        public ActionResult Welc( string welc = "Привет")
        {
            ViewBag.WelcText = welc;
            return View();
        }
        

    }
}