using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class RaceCondition
    {
        int randInt;
        Random random = new Random();
        Mutex mutex = new Mutex();

        void Printer()
        {
            long i = 100000;
            while (i > 0)
            {
                mutex.WaitOne();
                if (randInt % 5 == 0)
                {
                    if (randInt % 5 != 0)
                    {
                        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} - {randInt} is not divisible by 5");
                    }
                }
                mutex.ReleaseMutex();
                i--;
            }
        }

        void Modifier()
        {
            long i = 100000;
            while (i > 0)
            {
                mutex.WaitOne();
                randInt = random.Next(1000);
                mutex.ReleaseMutex();
                //Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is generating {randInt}");
                i--;
            }
        }

        public void RunTest()
        {
            Thread thread1 = new Thread(Printer);
            Thread thread2 = new Thread(Modifier);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

        }
    }
}
