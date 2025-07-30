using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class SinglevsMultipleThreads
    {
        // This class can be used to demonstrate the differences between single-threaded and multi-threaded execution.  
        // You can implement methods to run tasks in a single thread and in multiple threads, and compare their performance.  
        private static readonly long START = 0;
        private static readonly long END = int.MaxValue;

        long CalculateSum(long start, long end)
        {
            long sum = 0;
            for (long i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        void RunSingleThreadTest()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Thread thread = new Thread(() =>
            {
                long sum = CalculateSum(START, END);
                Console.WriteLine($"Single Thread Sum: {sum}");
            });
            thread.Start();
            thread.Join();
            stopwatch.Stop();
            Console.WriteLine($"Single Thread Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        }

        void RunMultipleThreadTest()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            long mid = (START + END) / 2;
            long totalSum = 0;
            Thread thread1 = new Thread(() =>
            {
                long sum1 = CalculateSum(START, mid);
                totalSum += sum1;
                Console.WriteLine($"Thread 1 Sum: {sum1}");
            });
            Thread thread2 = new Thread(() =>
            {
                long sum2 = CalculateSum(mid + 1, END);
                totalSum += sum2;
                Console.WriteLine($"Thread 2 Sum: {sum2}");
            });
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
            stopwatch.Stop();
            Console.WriteLine($"Total sum : {totalSum}");
            Console.WriteLine($"Multiple Threads Execution Time: {stopwatch.ElapsedMilliseconds} ms");
        }

        public void RunTest()
        {
            RunSingleThreadTest();
            RunMultipleThreadTest();
        }
    }    
}
