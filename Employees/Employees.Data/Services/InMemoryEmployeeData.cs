using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public class InMemoryEmployeeData : IEmployeeData
    {
        List<Employee> employees;
        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }
    }
}
