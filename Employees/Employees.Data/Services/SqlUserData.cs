using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public class SqlUserData : IUserData
    {
        private EmployeeDbContext db;

        public SqlUserData(EmployeeDbContext db)
        {
            this.db = db;
        }
        public void AddUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
    }
}
