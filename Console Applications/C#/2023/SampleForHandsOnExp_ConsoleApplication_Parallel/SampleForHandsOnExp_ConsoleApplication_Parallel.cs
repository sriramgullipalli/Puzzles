using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Parallel
{
    internal class SampleForHandsOnExp_ConsoleApplication_Parallel
    {
        static void Main(string[] args)
        {
            //Normal Count check.
            var stpWatch = new Stopwatch();
            stpWatch.Start();
            Console.WriteLine("Normal : " + GetEventCount(2, 10000000) + " Stopwatch : "+ stpWatch.Elapsed.Ticks.ToString());
            stpWatch.Stop();
            stpWatch.Reset();

            //Parallel
            int splitPart = 10;
            int result = 0;
            var stpWatchParallel = new Stopwatch();
            stpWatchParallel.Start();
            Parallel.For(0, splitPart, i => result = GetEventCount(i == 0 ? 2 : (i* 1000000 + 1),(i+1)* 1000000));
            Console.WriteLine("Parallel : " + result.ToString() + " Stopwatch : " + stpWatchParallel.Elapsed.Ticks.ToString());
            stpWatchParallel.Stop();
            stpWatchParallel.Reset();

        }

        public static int GetEventCount(int minVal, int maxVal)
        {
            int primeCount = 0;
            for(int i = minVal; i<maxVal; i++)
            {
                if(i%2 == 0) primeCount++;
            }
            return primeCount;
        }
    }
}
