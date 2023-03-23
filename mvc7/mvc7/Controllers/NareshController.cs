using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc7.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Name(string f,string l)
        {
            string s = f+l;
            ViewBag.s = s;
            
            return View();
        }
        public int Val(int a,int b)
        {
            return (a + b);
        }
        public ActionResult Sum(int x,int y)
        {
            return View(x+y);
        }
    }
}