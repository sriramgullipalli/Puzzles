using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_Structures
{
    public struct Parent
    {
        /*public Parent()
        {
            Console.WriteLine("Parent class.");
        }*/
        public void print()
        {
            Console.WriteLine("Parent print method.");
        }
    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_Structures
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.print();
        }
    }
}
