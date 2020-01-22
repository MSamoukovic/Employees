using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public interface IEmployeeData
    {
        IEnumerable<Employee> GetAll();
        void AddEmployee(Employee employee);
        Employee GetId(int employeeId);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}
