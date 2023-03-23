using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models
{
    public class EmpRepository
    {
        public void InsertEmp(Employee emp)
        {
            mvc1Entities db = new mvc1Entities();
            db.Employees.Add(emp);
            db.SaveChanges();
        }
    }
}