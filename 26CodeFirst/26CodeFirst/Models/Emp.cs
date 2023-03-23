using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _26CodeFirst.Models
{
    public class Emp
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
    }
}