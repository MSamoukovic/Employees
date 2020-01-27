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

        public SqlPersonData(EmployeeDbContext db)
        {
            this.db = db;
        }

        public void AddPerson(Person person)
        {
            db.Persons.Add(person);
            db.SaveChanges();
        }

        public IEnumerable<Person> GetAll()
        {
            return from p in db.Persons select p;
        }

        public Person GetId(int employeeId)
        {
            return db.Persons.FirstOrDefault(p => p.EmployeeId == employeeId);
        }
    }
}
