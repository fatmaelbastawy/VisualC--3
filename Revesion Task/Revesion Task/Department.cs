using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revesion_Task
{
    internal class EmployeeComparer : IComparer<Employee>
    {

        public int Compare(Employee x, Employee y)
        {
            return x.YearOfExperience.CompareTo(y.YearOfExperience);
        }

    
    }
    internal class Department

    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int NoOfEmployee { get; set; }
        public Employee[] Employees { get; set; }

    }
}
