using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Delegates
{
    class SimpleProgram
    {
        public delegate void ProgramDelegate(string message);

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
