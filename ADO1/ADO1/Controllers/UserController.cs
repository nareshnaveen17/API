using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO1.Models;

namespace ADO1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult New()
        {   
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Registration reg)
        {
            if (ModelState.IsValid)
            {
                RegistrationRepository rep = new RegistrationRepository();
                if(rep.Reg(reg))
                {
                    return RedirectToAction("LoginCheck");
                }
            }
            return View();
        }
        public ActionResult LoginCheck()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginCheck(Login obj)
        {
            if (ModelState.IsValid)
            {
                LoginRep s = new LoginRep();
                if (s.CheckUser(obj.Username, obj.Password))
                {
                    return View("Success", obj);
                }
                else
                {
                    ViewBag.m = "INvalid Username or PAssword";
                }
            }
            else
            {
                return View();
            }
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}