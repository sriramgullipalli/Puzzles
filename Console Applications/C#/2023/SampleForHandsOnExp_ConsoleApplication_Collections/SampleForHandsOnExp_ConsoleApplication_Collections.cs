using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Collections
{
    class SampleForHandsOnExp_ConsoleApplication_Collections
    {
        static void Main(string[] args)
        {

            Employee E1 = new Employee() { Id = 1, Name = "Sri", Salary = 2000 };
            Employee E2 = new Employee() { Id = 2, Name = "Ram", Salary = 3000 };
            Employee E3 = new Employee() { Id = 3, Name = "Mani", Salary = 4000 };
            Employee E4 = new Employee() { Id = 4, Name = "Kanta", Salary = 5000 };

            #region Dictionary
            //Dictionary code.
            Dictionary<int, Employee> EmployeeDict = new Dictionary<int, Employee>();
            EmployeeDict.Add(E1.Id, E1);
            EmployeeDict.Add(E2.Id, E2);
            EmployeeDict.Add(E3.Id, E3);
            EmployeeDict.Add(E4.Id, E4);

            foreach(KeyValuePair<int, Employee> kvp in EmployeeDict)
            {
                Console.WriteLine("Key : " + kvp.Key + " Name : " + kvp.Value.Name);
            }

            //ContainsKey code.
            if (EmployeeDict.ContainsKey(1))
            {
                Console.WriteLine("ContainsKey :- Id : " + EmployeeDict[1].Id + " Name : " + EmployeeDict[1].Name);
            }
            //TryGetValue code.
            Employee emp = new Employee();
            if(EmployeeDict.TryGetValue(2,out emp))
            {
                Console.WriteLine("TryGetValue :- Id : " + emp.Id + " Name : " + emp.Name);

            }

            //Count code
            Console.WriteLine("Count : " + EmployeeDict.Count(x => x.Value.Salary > 3000));

            //Arrays and List to Dictionary.
            Employee[] employeeArray = new Employee[4] { E1, E2, E3, E4 };
            List<Employee> employeeList = new List<Employee>() { E1, E2, E3, E4 };

            Dictionary<int,Employee> EmployeeArrayDict = employeeArray.ToDictionary(x => x.Id, x => x);
            Dictionary<int, Employee> EmployeeListDict = employeeList.ToDictionary(x => x.Id, x => x);

            foreach (KeyValuePair<int, Employee> kvp in EmployeeArrayDict)
            {
                Console.WriteLine("employeeArray :- Key : " + kvp.Key + " Name : " + kvp.Value.Name);
            }
            foreach (KeyValuePair<int, Employee> kvp in EmployeeListDict)
            {
                Console.WriteLine("employeeList :- Key : " + kvp.Key + " Name : " + kvp.Value.Name);
            }
            #endregion

            #region List
            List<Employee> employeeListData = new List<Employee>() { E1, E2, E3 };
            employeeListData.Insert(0, E4);
            Console.WriteLine("------------- List --------------");
            Console.WriteLine("IndexOf :- " + employeeListData.IndexOf(E1));
            Console.WriteLine("Contains :- " + employeeListData.Contains(E1));
            Console.WriteLine("Exists :- " + employeeListData.Exists(employ => employ.Salary > 2000));
            Console.WriteLine("Find :- " + employeeListData.Find(employ => employ.Name.StartsWith("M")).Name);
            Console.WriteLine("FindIndex :- " + employeeListData.FindIndex(employ => employ.Name.StartsWith("R")));

            foreach(Employee employe in employeeListData)
            {
                Console.WriteLine("Name : " + employe.Name);
            }
            Employee[] empArray = employeeListData.ToArray();
            foreach(Employee em in empArray)
            {
                Console.WriteLine("Array :- Name : " + em.Name);
            }

            Employee E5 = new Employee() { Id = 5, Name = "Sr", Salary = 8000 };
            Employee E6 = new Employee() { Id = 6, Name = "Mk", Salary = 9000 };
            List<Employee> newEmployeeList = new List<Employee>() { E5, E6 };
            employeeListData.AddRange(newEmployeeList);
            List<Employee> empGetRangeList = employeeListData.GetRange(2, 3);
            //employeeListData.InsertRange(0,newEmployeeList);
            //employeeListData.RemoveRange(3, 1);

            employeeListData.Sort();
            //EmployeeSortClass esc = new EmployeeSortClass();
            //employeeListData.Sort(esc);
            foreach (Employee employe in employeeListData)
            {
                Console.WriteLine("After sort Name : " + employe.Name);
            }

            Console.WriteLine("TrueForAll :- " + employeeListData.TrueForAll(y => y.Salary > 500));
            ReadOnlyCollection<Employee> readList =  employeeListData.AsReadOnly();
            Console.WriteLine("Before Trim Capacity :" + employeeListData.Capacity);
            employeeListData.TrimExcess();
            Console.WriteLine("After Trim Capacity :" + employeeListData.Capacity);
            Console.WriteLine("Count :" + employeeListData.Count);
            #endregion

            #region Queue
            Queue<Employee> queue = new Queue<Employee>() ;
            queue.Enqueue(E1);
            queue.Enqueue(E2);
            queue.Enqueue(E3);
            queue.Enqueue(E4);
            queue.Dequeue();
            Employee queuePeek = queue.Peek();
            Console.WriteLine("Queue Contains : " + queue.Contains(E1) + " Count : " + queue.Count() + " Peek :" + queuePeek.Name);
            #endregion

            #region Stack
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Pop();
            Employee stackPeek = queue.Peek();
            Console.WriteLine("Stack Contains : " + stack.Contains(E1) + " Count : " + stack.Count() + " Peek :" + stackPeek.Name);
            #endregion
        }
    }
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return this.Name.CompareTo(other.Name);
        }

    }

    public class EmployeeSortClass : IComparer<Employee>
    {
        public int Compare(Employee E1, Employee E2)
        {
            return E1.Name.CompareTo(E2.Name);
        }
    }
}
