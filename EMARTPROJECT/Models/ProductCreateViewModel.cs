using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EMARTPROJECT.Models
{
    public class ProductCreateViewModel:SubCategory
    {
        //internal int sc_id;
        [Key]
        public int item_id { get; set; }
        public int s_id { get; set; }
        public double price { get; set; }
        public string item_name { get; set; }
        public int stock_number { get; set; }
        public int gst { get; set; }
        public IFormFile ItemPhoto { get; set; }
    }
}
