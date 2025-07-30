using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton? instance;
        private static readonly object lockObject = new object();   
        private ThreadSafeSingleton()
        {
        }
        public static ThreadSafeSingleton getInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                }
            }            
            return instance;
        }
    }
}
