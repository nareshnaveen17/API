using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DependencyInjection.Models;

namespace DependencyInjection.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        //EmpServiceFake f = new EmpServiceFake();
        EmpService f = new EmpService();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmpModel em)
        {
            Employee emp = new Employee();
            emp.EmpID = em.EmpID;
            emp.EmpName = em.EmpName;
            emp.Salary = em.Salary;
            f.InsertEmp(emp);
            return View("Suc");

        }
        public ActionResult Suc()
        {
            return View();
        }
    }
}