using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revesion_Task
{
    internal interface EmployeeCompare: IComparer<Employee>
    {
      public int Compare(Employee x,Employee y)
        {
            return x.YearOfExperience.CompareTo(y.YearOfExperience);
        }
    }
}    
