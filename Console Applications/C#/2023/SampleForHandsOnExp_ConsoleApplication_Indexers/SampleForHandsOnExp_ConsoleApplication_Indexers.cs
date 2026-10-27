using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Indexers
{
    class SampleForHandsOnExp_ConsoleApplication_Indexers
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            EmployeeList.Add(new Employee { Id = 1, Name = "Sri", Salary = 1000 });
            EmployeeList.Add(new Employee { Id = 2, Name = "Ram", Salary = 2000 });
            EmployeeList.Add(new Employee { Id = 3, Name = "Mani", Salary = 3000 });
            EmployeeList.Add(new Employee { Id = 4, Name = "Kanta", Salary = 4000 });

            Employee emp = new Employee(EmployeeList);
            Console.WriteLine(emp[1]);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        List<Employee> employees = new List<Employee>();
        public Employee(List<Employee> EmployeeList)
        {
            employees = EmployeeList;
        }
        public Employee()
        {
           
        }
        public string this[int Id]
        {
            set
            {
                employees.FirstOrDefault(x => x.Id == Id).Name = value;
            }
            get
            {
                return employees.FirstOrDefault(x => x.Id == Id).Name;
            }
        }
    }
}
