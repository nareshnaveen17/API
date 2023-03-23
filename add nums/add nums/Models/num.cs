using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace add_nums.Models
{
    public class num
    {   
        [Required]
       
        public int a { get; set; }
        [Required]
        public int b { get; set; }
    }
}