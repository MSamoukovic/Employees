using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public class SqlEmployeeData : IEmployeeData
    {
        private readonly EmployeeDbContext db;

        public SqlEmployeeData(EmployeeDbContext db)
        {
            this.db = db;
        }

        public void AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public IEnumerable<Employee> GetAll()
        {
            return from e in db.Employees select e;
        }
    }
}
