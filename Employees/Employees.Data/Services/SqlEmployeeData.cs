﻿using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Delete(Employee employee)
        {
            db.Entry(employee).State = EntityState.Deleted;
            db.SaveChanges(); 
        }

        public IEnumerable<Employee> GetAll()
        {
            var query = from e in db.Employees select e;
            return query;
        }

        public Employee GetId(int employeeId)
        {
            return db.Employees.FirstOrDefault(e => e.Id == employeeId);
        }

        public void Update(Employee employee)
        {
            var entry = db.Entry(employee);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
