using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public class SqlPersonData : IPersonData
    {
        private EmployeeDbContext db;

        public SqlPersonData(EmployeeDbContext dbb)
        {
            this.db = dbb;
        }

        public void AddPerson(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }
    }
}
