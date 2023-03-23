using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using webAPI1.Models;
namespace webAPI1.Controllers
{
    public class NewController : ApiController
    {
        public List<Employee> Get()
        {
            mvc1Entities1 en = new mvc1Entities1();
            List<Employee> obj = en.Employees.ToList();
            return obj;
        }
    }
}
