using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc8.Controllers
{   public class Student
    {
        public int sno { get; set; }
        public string sname { get; set; }
        public double fee { get; set; }
    }
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult Index()
        {
            List<Student> st = new List<Student>();
            st.Add(new Student {sno=1,sname="Naresh",fee=7899 });
            st.Add(new Student { sno = 2, sname = "Om", fee = 17899 });
            st.Add(new Student { sno = 3, sname = "MAhesh", fee = 7800 });
            st.Add(new Student { sno = 4, sname = "Suresh", fee = 1699 });
            ViewBag.a = st;
            return View();
        }
    }
}