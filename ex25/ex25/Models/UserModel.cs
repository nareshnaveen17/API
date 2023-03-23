using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ex25.Models
{
    public class UserModel
    {
        [Required]
        [StringLength(40)]
        [System.Web.Mvc.Remote("CheckUsername", "Emp", ErrorMessage = "Username already exists")]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [StringLength(20)]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string CPassword { get; set; }
        [Required]
        [StringLength(40)]
        [RegularExpression(@"\D{1,40}", ErrorMessage = "Only alphabets are allowed")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40)]
        [RegularExpression(@"\D{1,40}", ErrorMessage = "Only alphabets are allowed")]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [StringLength(20)]
        [RegularExpression(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})", ErrorMessage = "Invalid Mail id")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(18, 70)]
        public int Age { get; set; }
        public string State { get; set; }
        public bool RecieveNewsLetters { get; set; }
        public string Hobbies { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Subscription")]
        public DateTime DateOfSubscription { get; set; }
        [Required]
        [Display(Name = "Country")]
        public int CountryID { get; set; }
        public string MaritialStatus { get; set; }
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public double RegistrationFee { get; set; }
    }
}