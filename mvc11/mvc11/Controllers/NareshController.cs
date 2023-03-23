using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc11.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Index()
        {
            return View("~/Views/Naresh/MyPage.cshtml");
        }
    }
}