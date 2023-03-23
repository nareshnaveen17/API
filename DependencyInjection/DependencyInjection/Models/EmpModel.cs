using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DependencyInjection.Models
{
    public class EmpModel
    {
        [Required]
        public int EmpID { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}