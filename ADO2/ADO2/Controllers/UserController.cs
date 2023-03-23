using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADO2.Models;
                                                                           
namespace ADO2.Controllers
{
    public class UserController : Controller 
    {
        // GET: User
        public ActionResult GetUsers()
        {
            UserRep obj = new UserRep();
            return View(obj.GetUser());
        }
    }
}