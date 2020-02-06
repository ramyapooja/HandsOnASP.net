using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public interface IEmployee
    {
        Employee GetEmployee(int id);
        List<Employee> DisplayDetails();
        bool AddEmployee(Employee employee);
    }
}
