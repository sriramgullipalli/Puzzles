using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_Interfaces
{
    public class Sample
    {
    }
    interface I1
    {
        void print();
    }
    interface I2
    {
        void print();
    }
    class AllowClassAndInterfaceInheritance : Sample, I1
    {
        public void print()
        {

        }
    }

    class ExplicitInterfaceInheritance : I1, I2
    {
        void I1.print()
        {
            Console.WriteLine("I1");
        }
        void I2.print()
        {
            Console.WriteLine("I2");
        }

    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_Interfaces
    {
        static void Main(string[] args)
        {
            ExplicitInterfaceInheritance explicitInterfaceInheritance = new ExplicitInterfaceInheritance();
            ((I1)explicitInterfaceInheritance).print();
            ((I2)explicitInterfaceInheritance).print();

            I1 i1 = new ExplicitInterfaceInheritance();
            I2 i2 = new ExplicitInterfaceInheritance();
            i1.print();
            i2.print();
        }
    }
}
