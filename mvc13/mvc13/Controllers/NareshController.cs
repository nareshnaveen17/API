using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc13.Models;

namespace mvc13.Controllers
{
    public class NareshController : Controller
    {
        // GET: Naresh
        public ActionResult ShowJobs()
        {
            List<Job> jobs = new List<Job>();
            Job j1 = new Job() { id = 1, name = "Dev" };
            Job j2 = new Job() { id = 2, name = "Eng" };
            Job j3 = new Job() { id = 3, name = "HR" };
            jobs.Add(j1);
            jobs.Add(j2);
            jobs.Add(j3);

            return View(jobs);
        }
    }
}