using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    public class ThreadStartProgram
    {
        void SayHello()
        {
            Console.WriteLine($"Hello from thread {Thread.CurrentThread.ManagedThreadId}!");
        }
        static void SayHi()
        {
            Console.WriteLine($"Hi from thread {Thread.CurrentThread.ManagedThreadId}!");
        }
        public void RunTest()
        {
            ThreadStart threadStart = new ThreadStart(SayHi);
            Thread thread = new Thread(threadStart);
            thread.Start();
            thread.Join();

            threadStart = new ThreadStart(SayHello);
            thread = new Thread(threadStart);
            thread.Start();
            thread.Join();
        }
    }
}
