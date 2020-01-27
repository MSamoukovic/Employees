using Employees.Data.Models;
using Employees.Data.Services;
using Employees.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Web.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public IPersonData personDb;
        public IEmployeeData employeeDb;
        
        public PersonController(IPersonData personDb, IEmployeeData employeeDb)
        {
            this.personDb = personDb;
            this.employeeDb = employeeDb;
        }
       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Person person)
        {
            personDb.AddPerson(person);
            return RedirectToAction("Index");
        }

        public ActionResult Show()
        {
            List<Data.Models.Employee> em = employeeDb.GetAll().ToList();
            List<Data.Models.Person> pe = personDb.GetAll().ToList();

            var model = from e in em
                        join p in pe on e.Id equals p.EmployeeId
                        select new PersonEmployee { FirstName=e.FirstName, LastName=e.LastName,Age=p.Age, PhoneNumber=p.PhoneNumber };

            return View(model);
        }
    }
}