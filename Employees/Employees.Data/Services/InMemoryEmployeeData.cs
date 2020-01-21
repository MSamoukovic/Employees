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

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetId(int employeeId)
        {
            return employees.FirstOrDefault(e=>e.Id==employeeId);
        }

        public void Update(Employee employee)
        {
            var model = GetId(employee.Id);
            model.FirstName=employee.FirstName;
            model.LastName = employee.LastName;
            model.Email = employee.Email;


        }
    }
}
