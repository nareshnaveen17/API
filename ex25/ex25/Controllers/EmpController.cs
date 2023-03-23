using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ex25.Models;

namespace ex25.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        FormEntities obj = new FormEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            var temp = obj.Countries.ToList<Country>();
            ViewBag.CountriesList = temp;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User s)
        {
           
                var b = obj.Entry(s);
                b.State = EntityState.Added;
                obj.SaveChanges(); 
                return RedirectToAction("Index");
            
           // return View();
        }
        public ActionResult CheckUsername(string Username)
        {
            bool IsValid = true;
            var res = obj.Users.SingleOrDefault<User>(c => c.Username == Username);
            if (res == null)
            {
                IsValid = true;
            }
            else
            {
                IsValid = false;
            }  
            return Json(IsValid, JsonRequestBehavior.AllowGet);
        }
        
    }
}