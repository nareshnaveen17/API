using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using add_nums.Models;

namespace add_nums.Controllers
{
    public class NumController : Controller
    {
        // GET: Num
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(num num)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Value = num.a + num.b;
            }
            return View(num);
        }
    }
}