using Employees.Data.Models;
using Employees.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployeeData db;

        public EmployeeController(IEmployeeData db)
        {
            this.db = db;
        }

        public ActionResult Index(string searchString)
        {
            Console.WriteLine("search : " +searchString);
            var model = db.GetAll();

            if (!String.IsNullOrEmpty(searchString))
            {
                model = model.Where(e => e.FirstName.Contains(searchString));
            }
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            db.AddEmployee(employee);

            return View();
        }

        public ActionResult Edit(int id)
        {
            var model = db.GetId(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Update(employee);
                TempData["Message"] = "You have saved the employee!";
            }
            return View(employee);
        }

        public ActionResult Details(int id)
        {
            var model = db.GetId(id);
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = db.GetId(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Employee employee)
        {
            db.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}