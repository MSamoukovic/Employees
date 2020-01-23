using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Web.Models
{
    public class Searching : Employee
    {
        public List<Employee> employeeList= new List<Employee>();
        public string textFromSearchBox { get; set; }
    }
}