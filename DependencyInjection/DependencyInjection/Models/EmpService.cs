using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models
{
    public class EmpService
    {
        public void InsertEmp(Employee emp)
        {
            EmpRepository rep = new EmpRepository();
            rep.InsertEmp(emp);
        }
    }
}