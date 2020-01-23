using Employees.Data.Models;
using Employees.Data.Services;
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
        public IPersonData dbb;
        public PersonController(IPersonData dbb)
        {
            this.dbb = dbb;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Person person)
        {
            dbb.AddPerson(person);
            return View();
        }
    }
}