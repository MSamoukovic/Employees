using Employees.Data.Models;
using Employees.Data.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees.Web.Controllers
{
    public class AccountController : Controller
    {
        public IUserData db;

        public AccountController(IUserData db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            db.AddUser(user);
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            using (EmployeeDbContext dd = new EmployeeDbContext())
            {
                var usr = dd.Users.Single(u => u.Username == user.Username && u.Password == user.Password);

                if (usr != null)
                {
                    Session["UserId"] = usr.UserId.ToString();
                    Session["Username"] = usr.Username.ToString();
                    return RedirectToAction("LoggedIn");
                }
        }
                return View();
        }
        public ActionResult LoggedIn( )
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }

        }


    }
}