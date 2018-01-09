using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebAPIdemo.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=ProductsDb")
        { }

        public DbSet<Product> Products { get; set; }

    }
}