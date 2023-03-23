using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace _26CodeFirst.Models
{
    public class EmpContext:DbContext
    {   
        public EmpContext() : base("con1") { }
        public DbSet<Emp> Emps { get; set; }
    }
}