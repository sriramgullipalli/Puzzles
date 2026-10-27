using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication
{
    class Parent
    {
        static Parent()
        {
            Console.WriteLine("Parent Static Constructor.");
        }
        public Parent()
        {
            Console.WriteLine("Parent Instance Constructor.");
        }
    }
    class Child : Parent
    {
        static Child()
        {
            Console.WriteLine("Child Static Constructor.");
        }
        public Child()
        {
            Console.WriteLine("Child Instance Constructor.");
        }
    }
    class SampleForHandsOnExp_ConsoleApplication
    {
        static void Main(string[] args)
        {
            Child child = new Child();
        }
    }
}
