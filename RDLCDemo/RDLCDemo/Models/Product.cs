using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RDLCDemo.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price{ get; set; }
    }
}