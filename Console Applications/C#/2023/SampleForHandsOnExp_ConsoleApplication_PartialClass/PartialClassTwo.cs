using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_PartialClass
{
    partial class PartialClass
    {

        partial void GetName()
        {
            Console.WriteLine(Name);
        }
    }
}
