using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Delegates
{
    public delegate int MultiCastDelegate();
    class MulticastDelegateClass
    {
        public static int SampleMethodOne()
        {
            return 1;
        }
        public static int SampleMethodTwo()
        {
            return 2;
        }
        public static int SampleMethodThree()
        {
            return 3;
        }
    }
}
