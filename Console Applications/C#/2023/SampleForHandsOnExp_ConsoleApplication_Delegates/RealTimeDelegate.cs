using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Delegates
{
    public delegate bool isSuperPatronDelegate(Info info);
    public class Info
    {
        public int Id { get; set; }
        public int numOfProducts { get; set; }
        public int registrations { get; set; }

        public static void isSuperPatron(List<Info> InfoList, isSuperPatronDelegate isSuperPatronDelegate)
        {
            List<int> res = new List<int>();
            foreach(Info info in InfoList)
            {
                if (isSuperPatronDelegate(info))
                {
                    res.Add(info.Id);
                    Console.WriteLine(info.Id);
                }
            }
           
        }
    }

}
