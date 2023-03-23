using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{   public class bigil
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public double sal { get; set; }
           
    }
    public class bigilController : Controller
    {
        // GET: bigil
        public ActionResult GetData()
        {
            List<bigil> sobj = new List<bigil>();
            sobj.Add(new bigil() { eno = 101, ename="nji",sal=8900});
            sobj.Add(new bigil() { eno = 102, ename = "mintu", sal = 8976 });
            ViewBag.s = sobj;

            return View();
        }
    }
}