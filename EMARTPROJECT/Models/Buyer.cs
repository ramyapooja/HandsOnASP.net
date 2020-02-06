using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EMARTPROJECT.Models
{
    public class Buyer
    {
        [Key]
        public int b_id { get; set; }
        public string b_username { get; set; }
        public string b_email_id { get; set; }
        [DataType("Password")]
        public string b_pwd { get; set; }
        public long b_pno { get; set; }
    }
}
