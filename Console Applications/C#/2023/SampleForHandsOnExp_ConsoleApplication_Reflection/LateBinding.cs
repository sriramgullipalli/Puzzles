using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Reflection
{
    public class LateBindingClass
    {
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}
