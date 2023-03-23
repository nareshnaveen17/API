using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ADO1.Models
{
    public class Registration
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name="Confirm Password")]
        public string CPWD { get; set; }
        [Required]
        
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"([6-9][0-9]{9})", ErrorMessage ="Invalid Phone Number") ]
        
        public string Mobile { get; set; }
    }
}