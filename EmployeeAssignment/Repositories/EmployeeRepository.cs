using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAssignment.Models;

namespace EmployeeAssignment.Repositories
{
    public class EmployeeRepository
    {
        static List<Employee> elist = new List<Employee>()
        {
            new Employee()
            {
                Eid=1,
                Name="sai",
                Designation="Manager",
                ProjectName="EmployeeManagement",
                Password="sai123"
            }
        };
            
        public EmployeeRepository()
        {

        }
        public void Add(Employee emp)
        {
            elist.Add(emp);
        }
        public Employee Validate(int Eid, string pwd)
        {
            foreach (var item in elist)
            {
                if (item.Eid == Eid && item.Password == pwd)
                {
                    return item;
                }

            }
            return null;
        }
    }
}
