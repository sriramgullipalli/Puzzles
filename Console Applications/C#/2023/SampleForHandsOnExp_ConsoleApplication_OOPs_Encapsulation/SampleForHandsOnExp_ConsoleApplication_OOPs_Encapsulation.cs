using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_Encapsulation
{
    class Employee
    {
        public int _id;
        public string _name;
       public void setId(int Id)
        {
            if(Id < 1)
            {
                throw new Exception("Enter valid Id.");
            }
            this._id = Id;
        }
        public void getId()
        {
            Console.WriteLine(this._id);
        }

        public string Name { 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter Name.");
                }
                this._name = value;
            }
            get
            {
                return this._name;
            }
        }

        public int Salary { set; get; }
    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_Encapsulation
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.setId(10);
            employee.getId();
            employee.Name = "Sriram";
            Console.WriteLine(employee.Name);
            employee.Salary = 1000;
            Console.WriteLine(employee.Salary);
        }
    }
}
