using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Generics
{
     class SampleForHandsOnExp_ConsoleApplication_Generics
    {
        static void Main(string[] args)
        {
             Console.WriteLine(GenericsClass<int>.Comparision(10, 10));
             Console.WriteLine(GenericsClass<string>.Comparision("Sri", "Ram"));
           
            //Equality comparision code.
            EqualityClass a = new EqualityClass();
            a.Name = "a";

            EqualityClass b = new EqualityClass();
            b.Name = "b";

            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));

            //String Builder code.
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("Sri");
            strBuilder.Append(" Ram");
            Console.WriteLine(strBuilder);
        }
    }

    class GenericsClass<G>
    {
        public static bool Comparision(G value1, G value2)
        {
            return value1.Equals(value2);
        }
    }

    class EqualityClass
    {
        public string Name { get; set; }
    }
}
