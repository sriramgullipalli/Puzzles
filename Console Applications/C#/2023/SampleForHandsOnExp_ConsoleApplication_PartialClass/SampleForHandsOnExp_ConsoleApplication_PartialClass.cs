using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_PartialClass
{
    internal class SampleForHandsOnExp_ConsoleApplication_PartialClass
    {
        static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.Name = "Sriram";
            partialClass.PublicGetName();
        }
    }
}
