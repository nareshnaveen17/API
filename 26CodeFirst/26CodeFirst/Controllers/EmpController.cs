using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _26CodeFirst.Models;

namespace _26CodeFirst.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            EmpContext con = new EmpContext();
            List<Emp> obj = con.Emps.ToList();
            return View(obj);
        }
    }
}