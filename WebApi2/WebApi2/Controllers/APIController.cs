using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi2.Models;

namespace WebApi2.Controllers
{
    public class APIController : ApiController
    {
        mvc1Entities en = new mvc1Entities();
        public List<Employee> Get(string s)
        {
            List<Employee> obj= en.Employees.Where(e=>e.EmpName.Contains(s)).ToList();
            return obj;
        }
        public string Post(Employee emp)
        {
            en.Employees.Add(emp);
            en.SaveChanges();
            return "Successfully Inserted";
        }
    }
}
