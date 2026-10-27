using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_MethodHiding
{
    class Parent
    {
       public void print()
        {
            Console.WriteLine("Parent class");
        }
    }
    class Child : Parent
    {
        public new void print()
        {
           //Parent class can be invoked by multiple ways.
           //1. base.print();
            Console.WriteLine("Child class");
        }
    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_MethodHiding
    {
        static void Main(string[] args)
        {
            /*2. Child child = new Child();
                 ((Parent)child).print();*/

            Parent parent = new Child();
            parent.print();
        }
    }
}
