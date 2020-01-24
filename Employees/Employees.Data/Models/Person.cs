using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Models
{
    public class Person 
    {
        public int Id { get; set; }
        public int Age { get; set; }

        [Required]
        [Display(Name="Phone number")]
        public string PhoneNumber { get; set; }

        //  [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
