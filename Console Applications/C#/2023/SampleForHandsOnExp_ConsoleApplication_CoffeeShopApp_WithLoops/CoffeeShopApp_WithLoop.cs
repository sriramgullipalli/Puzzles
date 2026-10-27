using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp_WithLoop
{
    class CoffeeShopApp_WithLoop
    {
        static void Main(string[] args)
        {
            int totalbill = 0;
            string moreReq = string.Empty;
            do
            {
                int pref = 0;
                do
                {
                    Console.WriteLine("Menu");
                    pref = Convert.ToInt32(Console.ReadLine());
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
                            break;
                    }
                } while (pref != 1 && pref != 2);
                Console.WriteLine("Any more");
                moreReq = Console.ReadLine().ToUpper();
                if (moreReq == "YES" || moreReq == "NO")
                {
                    Console.WriteLine(totalbill);
                }
                else
                {
                    Console.WriteLine("Enter valid choice.");
                }
            } while (moreReq != "NO");
        }
    }
}
