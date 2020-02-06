using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDataManagement.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public department Dept { get; set; }
    }
    public enum department
    {
        IT,Acoounts,Insurance,HealthCare
    }
}
