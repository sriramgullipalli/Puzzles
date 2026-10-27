using SampleForHandsOnExp_WebApplication_WCFServiceClient.WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_WebApplication_WCFServiceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloServiceClient helloServiceClient = new HelloServiceClient();
            Console.WriteLine(helloServiceClient.GetMessage("Sri"));
        }
    }
}
