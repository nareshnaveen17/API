using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc2.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult GetData()
        {
            ViewBag.a = 10;
            ViewBag.b = 20;
            return View();
        }
        public ActionResult GetVal()
        {
            int a = 100;
            return View(a);
        }
    }
}