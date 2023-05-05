using Revesion_Task;
using System.Collections.Immutable;

internal class Program
{
    private static void Main(string[] args)
    {
        #region
        //Employee employee = new Employee();
        //Employee employee1= new Employee();
        //employee1.YearOfExperience = 3;
        //Employee employee2 = new Employee();
        //employee2.YearOfExperience = 5;
        //Employee employee3 = new Employee();
        //employee3.YearOfExperience = 2;
        //Employee employee4 = new Employee();
        //employee4.YearOfExperience = 7;

        //Department department = new Department();
        //department.Employees[0] = employee1;
        //department.Employees[1] = employee2;
        //department.Employees[2] = employee3;
        //department.Employees[3] = employee4;



        //Array.Sort(department.Employees);
        //for (int i = 0; i < department.Employees.Length; i++)
        //{
        //    Console.WriteLine(department.Employees[i].YearOfExperience);
        //}


        Employee emp1 = new Employee(1, "Mohamed", 33, 5000, 2, "d1");
        Employee emp2 = new Employee(2, "Esmaeel", 26, 6000, 5, "d1");
        Employee emp3 = new Employee(3, "Hussin", 31, 4000, 3, "d1");
        Department dep = new Department("Backend", 20);


        Employee[] employeees = new Employee[3] { emp1, emp2, emp3 };   //array


        Console.WriteLine("-------------------(1,2,3)-----------------------");
        //Array.Sort(dep.employees);
        //for (int i = 0; i < employeees.Length; i++)
        //{
        //    Console.WriteLine(employeees[i]);
        //}

        //Array.Sort(dep.employees, new SalaryComparer()); // Icomparer
        //for (int i = 0; i < employeees.Length; i++)
        //{
        //    Console.WriteLine((employeees[i].Name, employeees[i].Salary));
        //}

        Console.WriteLine("-------------------(4)-----------------------");
        //------------------------------------(4)----------------------------------------


        dep.Allemployees = new List<Employee>() { emp1, emp2, emp3 };    //list 

        dep.Allemployees.Sort(new SalaryComparer());
        foreach (Employee employee in dep.Allemployees)
        {
            Console.WriteLine(employee.Salary);
        }
        Console.WriteLine("-------------------(5)-----------------------");
        //------------------------------------(5)----------------------------------------
        dep[1] = emp1;
        Console.WriteLine(dep[1].Name);


        Console.WriteLine("-------------------(6)-----------------------");
        //------------------------------------(6)----------------------------------------
        Department dep2 = new Department("Structure", 30);
        Employee emp4 = new Employee(4, "Ahmed", 25, 5000, 2, "d2");
        Employee emp5 = new Employee(5, "Omar", 28, 6000, 5, "d2");
        Employee emp6 = new Employee(6, "Ali", 27, 3000, 3, "d2");
        dep2.Allemployees = new List<Employee>() { emp4, emp5, emp6 };

        Console.WriteLine("-----------------Removing---------------------");
        emp1.depemployees += dep.Employeeremoving;
        emp1.Changedep();
        foreach (Employee emp in dep.Allemployees)
        {
            Console.WriteLine(emp.Name);
        }

        Console.WriteLine("-----------------Adding---------------------");
        emp1.depemployees += dep2.Employeeadding;
        emp1.Changedep();
        foreach (Employee emp in dep2.Allemployees)
        {
            Console.WriteLine(emp.Name);
        }
    }


    public delegate void Depemployees(Employee employee);
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int YearofExperience { get; set; }
        public string department { get; set; }


        public Employee(int _id, string _name, int _age, int _salary, int _yearofExperience, string _department)
        {
            this.Id = _id;
            this.Name = _name;
            this.Age = _age;
            this.Salary = _salary;
            this.YearofExperience = _yearofExperience;
            this.department = _department;

        }

        public int CompareTo(Employee? other)
        {
            return this.YearofExperience.CompareTo(other.YearofExperience);


        }
        public override string ToString()
        {
            return YearofExperience.ToString();
        }

        public event Depemployees depemployees;

        public void Changedep()
        {
            if (depemployees != null)
            {
                depemployees.Invoke(this);
            }
        }





    }



    class SalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }



    public class Department
    {

        public string Depname { get; set; }
        public int NoofEmployees { get; set; }
        public Employee[] employees { get; set; }

        public List<Employee> Allemployees { get; set; }

        public Department(string _depname, int _noofEmployees)
        {
            this.Depname = _depname;
            this.NoofEmployees = _noofEmployees;

        }


        //5//
        Dictionary<int, Employee> Dic = new Dictionary<int, Employee>();
        public Employee this[int id]
        {

            set
            {
                Dic[id] = value;
            }
            get
            {
                return Dic[id];
            }
        }


        public void Employeeremoving(Employee emp)
        {
            Allemployees.Remove(emp);
        }
        public void Employeeadding(Employee emp)
        {
            Allemployees.Add(emp);
        }


    } }

    