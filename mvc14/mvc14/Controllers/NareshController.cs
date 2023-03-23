using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc14.Controllers;
using mvc14.Models;

namespace mvc14.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Show()
        {
            Emp e = new Emp();
            e.eid = 1;
            e.ename = "naresh";
            e.sal = 67890;

            Product p = new Product();
            p.pid = 101;
            p.pname = "Soap";
            p.price = 67;

            EmpandProduct n = new EmpandProduct();
            n.em = e;
            n.prod = p;
            return View(n);
        }
    }
}