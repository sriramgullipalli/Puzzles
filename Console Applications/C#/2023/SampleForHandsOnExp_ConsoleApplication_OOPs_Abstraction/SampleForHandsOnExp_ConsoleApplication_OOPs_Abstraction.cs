using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_OOPs_Abstraction
{
    public abstract class Sample
    {
        public int id = 0;
        public abstract string Name { get; }
        public abstract void AbstractMethod();

        public void Print()
        {
            Console.WriteLine("Test.");
        }
    }
    abstract class AbstarctClassInherit : Sample
    {

    }

    class AbstractImplementation : AbstarctClassInherit
    {
        public override string Name => "Sriram";

        public override void AbstractMethod()
        {
            Console.WriteLine("Abstraction Method.");
        }
    }
    class SampleForHandsOnExp_ConsoleApplication_OOPs_Abstraction 
    {
        
        static void Main(string[] args)
        {
            AbstractImplementation abstractImplementation = new AbstractImplementation();
            abstractImplementation.AbstractMethod();
        }
    }
}
