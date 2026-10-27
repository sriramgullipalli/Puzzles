using SampleForHandsOnExp_WebApplication_WCFService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_WebApplication_WCFServiceHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(SampleForHandsOnExp_WebApplication_WCFService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host Started.");
                Console.ReadLine();
            }
        }
    }
}
