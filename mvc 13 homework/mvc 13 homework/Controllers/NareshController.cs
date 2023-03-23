using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_13_homework.Models;



namespace mvc_13_homework.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Show()
        {
            Student s = new Student();
            s.sid = 1;
            s.sname = "naresh";
            s.fee = 89908;

            Teacher t = new Teacher();
            t.tid = 11;
            t.tname = "sai";
            t.sal = 67874;

            ST st = new ST();
            st.stu = s;
            st.tea = t;
            return View(st);
        }
        public ActionResult GetExternalView()
        {
            return View("~/Views/Naresh/New.cshtml");
        }
    }
}