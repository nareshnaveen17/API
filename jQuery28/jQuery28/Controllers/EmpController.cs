using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using jQuery28.Models;

namespace jQuery28.Controllers
{
    public class EmpController : Controller
    {
        mvc1Entities db = new mvc1Entities();
        // GET: Emp
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult SearchEmp(string s)
        {
           
            List<Employee> obj = db.Employees.Where(x => x.EmpName.Contains(s)).ToList();

            return Json(obj, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Index1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(Employee emp)
        {
            mvc1Entities en = new mvc1Entities();
            en.Employees.Add(emp);
            en.SaveChanges();

            return Content("Inserted Successfully");
        }
        public ActionResult Index2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(Employee emp)
        {
            Employee e = db.Employees.Where(x => x.EmpID == emp.EmpID).FirstOrDefault();
            e.EmpID = emp.EmpID;
            e.EmpName = emp.EmpName;
            e.Salary = emp.Salary;
            db.SaveChanges();
            return Content("Updated Successfully");
        }
        public ActionResult Index3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int del)
        {
            mvc1Entities db = new mvc1Entities();
            Employee e = db.Employees.Where(x => x.EmpID == del).FirstOrDefault();
            db.Employees.Remove(e);
            db.SaveChanges();
            return Content("Deleted Successfully");
        }
    }
}