using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductWebApi.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
        }

        public System.Data.Entity.DbSet<ProductWebApi.Models.Product> Products { get; set; }

    }
}