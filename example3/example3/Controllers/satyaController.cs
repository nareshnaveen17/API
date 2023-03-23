using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using example3.Models;

namespace example3.Controllers
{
    public class satya
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public double sal { get; set; }
    }
    public class satyaController : Controller
    {
        // GET: satya
        public ActionResult getdata()
        {
            List<satya> sobj = new List<satya>();
            sobj.Add(new satya() { eno = 101, ename = "rahul", sal = 25000 });
            sobj.Add(new satya() { eno = 102, ename = "koko", sal = 15000 });
            sobj.Add(new satya() { eno = 103, ename = "roro", sal = 35000 });
             satya sobj1 = new satya();
            sobj1.eno = 104;
            sobj1.ename = "bhbh";
            sobj1.sal = 26000;
            ViewBag.s = sobj;
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie m )
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("getdata");
            }
            return View(m);
        }

    }
}