using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc4.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public string dis(string s)
        {
            return s;
        }
        public int dis1(int a)
        {
            return a;
        }  
        public int dis2(int a,int b)
        {
            return (a + b);
        }
        public string dis3(int id,string s)
        {
            string str = s + " " + id;
            return str;
        }
        public string dis4()
        {
            return "<h1> NARESH KUMAR </h1>";

        }
        public JsonResult dis5()
        {
            List<string> obj = new List<string>();
            obj.Add("NAresh");
            obj.Add("Sai");
            obj.Add("hi");
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Index()
        {
            return View();
        }
    }
}