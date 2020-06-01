using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzuxServer.Models
{
    public class ProductDTO:Product
    {
        public override Category Category { get; set; }
        public ProductDTO()
        {
            using(var db = new AzuxDBEntities())
            {
                Category = db.Category.Find(CategoryId);
            }
        }
    }
}