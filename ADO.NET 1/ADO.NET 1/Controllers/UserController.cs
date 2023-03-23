using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO.NET_1.Models;

namespace ADO.NET_1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login obj)
        {
            if (ModelState.IsValid)
            {
                Class1 c = new Class1();
                if (c.CheckUser(obj.Username, obj.Password))
                {
                    return View("Success", obj);
                }
                else
                {
                    ViewBag.x = "Invalid Username or Password";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}