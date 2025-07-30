using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    public class LazySingleton
    {
        private static LazySingleton? instance;
        private LazySingleton() 
        {           
        }
        public static LazySingleton getInstance()
        {
            if (instance == null)
            {
                instance = new LazySingleton();
            }
            return instance;
        }
    }
}
