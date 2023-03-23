using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using jQuery27.Models;

namespace jQuery27.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SearchEmp(string s)
        {
            mvc1Entities en = new mvc1Entities();
            List<Employee> emp = en.Employees.Where(x => x.EmpName.Contains(s)).ToList();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
    }
}