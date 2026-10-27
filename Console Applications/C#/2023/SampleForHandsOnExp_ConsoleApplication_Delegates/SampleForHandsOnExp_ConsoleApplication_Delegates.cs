using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static SampleForHandsOnExp_ConsoleApplication_Delegates.SimpleProgram;

namespace SampleForHandsOnExp_ConsoleApplication_Delegates
{
    public delegate bool isPromotableDelegate(Employee employee);
   class SampleForHandsOnExp_ConsoleApplication_Delegates
    {
        static void Main(string[] args)
        {
            //Simple program code.
            ProgramDelegate programDelegate = new ProgramDelegate(Hello);
            programDelegate("Welcome Back");

            //Info file code.
            List<Info> InfoList = new List<Info>();
            InfoList.Add(new Info {Id = 1, numOfProducts = 3, registrations = 500 });
            InfoList.Add(new Info {Id = 2, numOfProducts = 5, registrations = 600 });
            Info.isSuperPatron(InfoList, x => x.numOfProducts > 4);

            //Current file code.
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { ID = 1, Name = "Sri", Salary = 1000, Experience = 4});
            employees.Add(new Employee { ID = 2, Name = "Ram", Salary = 2000, Experience = 5 });
            employees.Add(new Employee { ID = 3, Name = "Mani", Salary = 3000, Experience = 3 });
            employees.Add(new Employee { ID = 4, Name = "Kanta", Salary = 4000, Experience = 2 });

            //Using Lamba function.
            //Employee.Promotion(employees, x => x.Salary > 2000);
            Employee.Promotion(employees, isPromotable);

            //MultiCastDelegate code.
            MultiCastDelegate multiCastDelegate = new MultiCastDelegate(MulticastDelegateClass.SampleMethodOne);
            multiCastDelegate += MulticastDelegateClass.SampleMethodTwo;
            Console.WriteLine("MultiCastDelegate : " + multiCastDelegate());

        }
        public static bool isPromotable(Employee employee)
        {
            if(employee.Salary > 2000)
            {
                return true;
            }
            return false;
        }
    }

    public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
        public int Experience { set; get; }

        public static void Promotion(List<Employee> employees, isPromotableDelegate isPromotable)
        {            
            foreach (Employee employee in employees)
            {
                if (isPromotable(employee))
                {
                    Console.WriteLine(employee.Name + " is Promoted.");
                }
            }
        }
    }
}
        
