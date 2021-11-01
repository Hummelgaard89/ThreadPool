using System;
using System.Threading;
using System.Diagnostics;

namespace ThreadPooling
{
    class ThreadPoolDemo
    {

        public static void Main(string[] args)
        {
            Stopwatch mywatch = new Stopwatch();
            Console.WriteLine("Thread Pool Execution");

            mywatch.Start();
            ProcessWithThreadPoolMethod();
            mywatch.Stop();
            Console.WriteLine(" It took " + mywatch.ElapsedMilliseconds.ToString() + " to execute with Pool");
            mywatch.Reset();

            Console.WriteLine("Thread Execution");
            mywatch.Start();
            //ProcessWithThreadMethod();
            mywatch.Stop();
            Console.WriteLine(" It took " + mywatch.ElapsedMilliseconds.ToString() + " to execute withput Pool");
            Console.ReadLine();
            
        }

        static void Process(object callback)
        {
            for (int i = 0; i < 100000000; i++)
            {
                //for (int j = 0; j < 100000000; j++)
                //{
                    
                //}
                
            }
        }

        static void ProcessWithThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread obj = new Thread(Process);
                obj.Start();
                Console.WriteLine(obj.IsAlive);
                Console.WriteLine(obj.IsBackground);
                Console.WriteLine(obj.Priority);
            }
        }

        static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Process);
                Console.WriteLine("IsThreadPoolThread == " + Thread.CurrentThread.IsThreadPoolThread);
                Console.WriteLine("IsAlive == " + Thread.CurrentThread.IsAlive);
                Console.WriteLine("Priority == " + Thread.CurrentThread.Priority);
                Console.WriteLine("IsBackground == " + Thread.CurrentThread.IsBackground);
                Console.WriteLine();
            }
        }

    }
}