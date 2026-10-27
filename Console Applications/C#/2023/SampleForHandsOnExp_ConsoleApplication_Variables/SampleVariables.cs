using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication
{
    class SampleVariables
    {
        static int staticVar = 200;
        static void Main(string[] args)
        {
            int nrmlVaar = 100;
            const int constVar = 100;

             // constVar = constVar + 100;
            nrmlVaar = nrmlVaar + 1;            
            staticVar = staticVar + 100;

            Console.WriteLine("constVar : " + constVar + "staticVar : " + staticVar + "nrmlVaar : " + nrmlVaar);
        }
    }
}
