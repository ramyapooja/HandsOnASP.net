using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EMARTPROJECT.Models
{
    public class SellerCreateViewModel
    {
        [Key]
        public int s_id { get; set; }
        public string s_username { get; set; }
        [DataType("Password")]
        public string s_pwd { get; set; }

        public int GSTIN { get; set; }

        public string s_email_id { get; set; }

        public long sbank_accno { get; set; }
        public IFormFile photopath { get; set; }
    }
}
