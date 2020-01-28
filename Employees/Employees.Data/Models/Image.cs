using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Employees.Data.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }


        //da sam sigurna da ovo ne ide u bazu
        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}
