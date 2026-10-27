using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleForHandsOnExp_ConsoleApplication_Threads
{
    public delegate void PrintSumCallBackDelegate(int sum);
     class SampleForHandsOnExp_ConsoleApplication_Threads
    {
        
        static void Main(string[] args)
        {
            #region Without TypeSafe code implementation.
            Console.WriteLine("--------------Without TypeSafe code implementation.--------------------");
            Console.WriteLine("Enter Target :");
            Object Target = Console.ReadLine();
            ThreadsFunction threadsFunction = new ThreadsFunction();
            Thread thread = new Thread(threadsFunction.PrintNumWithoutTypeSafe);
            thread.Start(Target);

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(threadsFunction.PrintNumWithoutTypeSafe);
            Thread parameterizedThread = new Thread(parameterizedThreadStart);
            parameterizedThread.Start(Target);
            #endregion

            #region With TypeSafe code implementation.

            Console.WriteLine("--------------With TypeSafe code implementation.--------------------");
            Console.WriteLine("Enter Target :");
            int target = Convert.ToInt32(Console.ReadLine());
            ThreadsFunction threadsFunctionWithTypeSafe = new ThreadsFunction(target);
            Thread threadwithTypeSafe = new Thread(threadsFunctionWithTypeSafe.PrintNumWithTypeSafe);
            threadwithTypeSafe.Start();
            #endregion

            #region Call Back code implementation.
            Console.WriteLine("--------------With CallBack implementation.--------------------");
            PrintSumCallBackDelegate printSumDelegate = new PrintSumCallBackDelegate(PrintSum);
            Console.WriteLine("Enter Target :");
            int targetSum = Convert.ToInt32(Console.ReadLine());
            ThreadsFunction threadsFunctionWithCallBack = new ThreadsFunction(targetSum, printSumDelegate);
            Thread threadwithCallBack = new Thread(threadsFunctionWithCallBack.PrintSum);
            threadwithCallBack.Start();
            #endregion

            #region Join And Alive code implementation.
            Thread threadJoinMethodOne = new Thread(ThreadJoinMethodOne);
            threadJoinMethodOne.Start();
            threadJoinMethodOne.Join(1000);
            Thread threadJoinMethodTwo = new Thread(ThreadJoinMethodTwo);
            threadJoinMethodTwo.Start();

            for (int i = 0; i < 5; i++)
            {
                if (threadJoinMethodOne.IsAlive)
                {
                    Console.WriteLine("ThreadJoinMethodOne Alive.");
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("ThreadJoinMethodOne Completed."); break;
                }
            }

            #endregion

            #region Locks code implementation.
            Thread LockThreadOne = new Thread(LockedThreadMethod);
            Thread LockThreadTwo = new Thread(LockedThreadMethod);
            Thread LockThreadThree = new Thread(LockedThreadMethod);
            LockThreadOne.Start();
            LockThreadTwo.Start();
            LockThreadThree.Start();
            LockThreadOne.Join();
            LockThreadTwo.Join();
            LockThreadThree.Join();

            Console.WriteLine(total);
            #endregion

        }

        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum : " + sum);
        }
        public static void ThreadJoinMethodOne()
        {
            Console.WriteLine("ThreadJoinMethodOne started");
            Thread.Sleep(5000);
            Console.WriteLine("ThreadJoinMethodOne Ended");
        }
        public static void ThreadJoinMethodTwo()
        {
            Console.WriteLine("ThreadJoinMethodTwo started");
        }

        public static int total = 0;
        static object _lock = new object();
        public static void LockedThreadMethod()
        {     
            
            for(int i = 0; i < 10000; i++)
            {
                bool locked = false;
                Monitor.Enter(_lock, ref locked);
                try
                {
                    total++;
                }
                finally
                {
                    if (locked)
                    {
                        Monitor.Exit(_lock);
                    }                    
                }
               /* lock (_lock){
                    total++;
                }*/
               //Interlocked.Increment(ref total);
            }
        }

    }

    class ThreadsFunction
    {
        public ThreadsFunction()
        {

        }
        public void PrintNumWithoutTypeSafe(Object target)
        {
            int num = 0;
            if (int.TryParse(Convert.ToString(target), out num))
            {
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        int _target;
        public ThreadsFunction(int target)
        {
            this._target = target;
        }
        public void PrintNumWithTypeSafe()
        {
            for (int i = 0; i < this._target; i++)
                {
                    Console.WriteLine(i);
                }
            }

        public PrintSumCallBackDelegate _printSumDelegate;
        public ThreadsFunction(int target, PrintSumCallBackDelegate printSumDelegate)
        {
            this._target = target;
            this._printSumDelegate = printSumDelegate;
        }
        public void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= this._target; i++)
            {
                sum += i;
            }
            if(this._printSumDelegate != null)
            {
                this._printSumDelegate(sum);
            }
        }
    }
        
}

