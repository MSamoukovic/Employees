using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employees.Web.Models
{
    public class CreatePerson
    {
        public int  Age { get; set; }
        [Required]
        [Display(Name="Phone number")]
        public string PhoneNumber { get; set; }

        public int EmployeeId { get; set; }
        public List<Employee> Employees { get; set; }
    }
}