using DocuSign.eSign.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Employees.Data.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

    }
}