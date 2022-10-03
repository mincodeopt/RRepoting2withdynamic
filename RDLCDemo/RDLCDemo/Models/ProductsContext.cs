using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RDLCDemo.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
            :base("dbconnection")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}