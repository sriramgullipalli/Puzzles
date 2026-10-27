using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication
{
    class CoffeeShopApp_WithLabel
    {
        static void Main(string[] args)
        {

            int totalbill = 0;

            PrefLabel:
            Console.WriteLine("Menu");
            int pref = Convert.ToInt32(Console.ReadLine());
            switch (pref)
            {
                case 1:
                    totalbill += 50;
                    break;
                case 2:
                    totalbill += 100;
                    break;
                default:
                    Console.WriteLine("Enter valid number.");
                    goto PrefLabel;
            }
            AnyMoreLabel:
            Console.WriteLine("Any more");
            string moreReq = Console.ReadLine().ToUpper();
            switch (moreReq)
            {
                case "NO":
                    Console.WriteLine(totalbill); break;
                case "YES":
                    goto PrefLabel;
                default:
                    Console.WriteLine("Enter valid choice.");
                    goto AnyMoreLabel;
            }
        }
    }
}
