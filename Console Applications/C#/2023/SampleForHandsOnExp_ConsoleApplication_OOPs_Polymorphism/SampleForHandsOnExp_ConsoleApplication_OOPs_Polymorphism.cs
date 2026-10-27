using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_Polymorphism
{
    class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("Parent class");
        }
    }
    class Child : Parent
    {
        public override void print()
        {
            Console.WriteLine("Child class");
        }
    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_Polymorphism
    {
        static void Main(string[] args)
        {
            Parent parent = new Child();
            parent.print();
        }
    }
}
