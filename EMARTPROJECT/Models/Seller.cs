using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EMARTPROJECT.Models
{
    public class Seller
    {
        [Key]
        public int s_id { get; set; }
        public string s_username { get; set; }
        [DataType("Password")]
        public string s_pwd { get; set; }
        
        public int GSTIN { get; set; }
       
        public string s_email_id { get; set; }
       
        public long sbank_accno { get; set; }
        public string photopath { get; set; }
    }
}
