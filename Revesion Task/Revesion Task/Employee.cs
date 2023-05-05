using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revesion_Task
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public int YearOfExperience { get; set; }
        public int Department { get; set; }
        public delegate void Handler(Employee e);
        public event Handler ChangeDep;

        public void ChangeDepartment(Employee e)
        {
            if (e.Department >= 4)

            {
                e.Department++;


                ChangeDep.Invoke(e);
            }


        }
    }
}
