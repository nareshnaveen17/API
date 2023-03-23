using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace mvc12.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Display(int id)
        {
            return View(id);
        }
        public ActionResult Show(int a)
        {
            ViewBag.b = a;
            return View();
        }
        public ActionResult Print(int b)
        {
            return View(b);
        }
        public ActionResult Eve(int a)
        {
           
            return View(a);
        }
        
    }
}