using Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Data.Services
{
    public class SqlImageData : IImageData
    {
        private EmployeeDbContext db;

        public SqlImageData(EmployeeDbContext db)
        {
            this.db = db;
        }
        public void AddImage(Image image)
        {
            db.Images.Add(image);
            db.SaveChanges();
        }
    }
}
