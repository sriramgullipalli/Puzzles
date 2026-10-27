using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleForHandsOnExp_ConsoleApplication_Extension_MethodsOrignial.Sample obj = new SampleForHandsOnExp_ConsoleApplication_Extension_MethodsOrignial.Sample();
            obj.Print();
            obj.Display();
            obj.ExtensionMethod();
        }       
    }
    static class ExtensionClass
    {
        public static void ExtensionMethod(this SampleForHandsOnExp_ConsoleApplication_Extension_MethodsOrignial
.Sample obj)
        {
            Console.WriteLine("ExtensionMethod Method.");
        }
    }
}
namespace SampleForHandsOnExp_ConsoleApplication_Extension_MethodsOrignial
{
    public class Sample
    {
        public void Print()
        {
            Console.WriteLine("Print Method.");
        }
        public void Display()
        {
            Console.WriteLine("Display Method.");
        }
    }

    
}
  