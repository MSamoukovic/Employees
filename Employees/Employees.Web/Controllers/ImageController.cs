using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employees.Data.Models;
using Employees.Data.Services;

namespace Employees.Web.Controllers
{
    public class ImageController : Controller
    {
        private IImageData db;


        public ImageController(IImageData db)
        {
            this.db = db;
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Image imageModel)
        {
            HttpPostedFileBase file = imageModel.ImageFile;

            string fileName = Path.GetFileNameWithoutExtension(file.FileName);
            string extension = Path.GetExtension(file.FileName);
            string name = fileName + extension;
            string path = "~/Image/" + name;

            file.SaveAs(Server.MapPath(path));
            imageModel.ImagePath = path;
            db.AddImage(imageModel);
            ModelState.Clear();
            return View();
        }
    }
}