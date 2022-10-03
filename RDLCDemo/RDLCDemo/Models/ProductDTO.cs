using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RDLCDemo.Models
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }
    }
}