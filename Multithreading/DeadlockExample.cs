using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    class DeadlockExample
    {
        private readonly Mutex lockA = new Mutex();
        private readonly Mutex lockB = new Mutex();

        void ThreadA()
        {
            lockA.WaitOne();
            Console.WriteLine($"Thread A (ID: {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name ?? "null"}) acquired lock A, waiting for lock B...");
            Thread.Sleep(100); // Simulate some work    
            lockB.WaitOne();
            Console.WriteLine($"Thread A (ID: {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name ?? "null"}) acquired lock B.");
            lockB.ReleaseMutex();
            lockA.ReleaseMutex();
        }
        void ThreadB()
        {
            lockB.WaitOne();
            Console.WriteLine($"Thread B (ID: {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name ?? "null"}) acquired lock B, waiting for lock A...");
            Thread.Sleep(100); // Simulate some work
            lockA.WaitOne();
            Console.WriteLine($"Thread B (ID: {Thread.CurrentThread.ManagedThreadId}, Name: {Thread.CurrentThread.Name ?? "null"}) acquired lock A.");
            lockA.ReleaseMutex();
            lockB.ReleaseMutex();
        }
        public void RunTest()
        {
            Thread thread1 = new Thread(ThreadA);
            Thread thread2 = new Thread(ThreadB);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }

    }
}
