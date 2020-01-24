using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employees.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name="Last name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        [Display(Name="Confirm email")]
        [Compare("Email", ErrorMessage = "The email and confirm email do not match.")]

        public string ConfirmEmail { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirm password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}