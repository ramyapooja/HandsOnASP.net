using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HandsOnMVCUsingModelValidations.Models
{
    public class User
    {
        [Required(ErrorMessage ="Pls enter name")]
        [StringLength(maximumLength:20,MinimumLength =4,ErrorMessage ="Name length should be 4 to 20")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Invalid email address")]
        
        public string Email { get; set; }
        
        public DateTime DOB { get; set; }
       [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid mobile number")]
        public string Mobileno { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Select Country")]
        public string Country { get; set; }
        [Required(ErrorMessage ="Pls enter username")]
        
        public string Uname { get; set; }
        [Required(ErrorMessage ="Pls enter password")]
        [RegularExpression(@"[a-z0-9]{6-8}")]
        public string Pwd { get; set; }

    }
}
