using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class BuilderDemo
    {
        public static void Main(string[] args)
        {
            HttpRequest request1 = new HttpRequest.Builder("https://api.example.com/data")
                .SetMethod("GET")
                .AddHeader("Authorization", "Bearer token")
                .AddHeader("Accept", "application/json")                
                .Build();
            Console.WriteLine(request1);
            HttpRequest request2 = new HttpRequest.Builder("https://api.example.com/data")
                .SetMethod("POST")
                .AddHeader("Content-Type", "application/json")
                .SetBody("{\"key\":\"value\"}")
                .Build();
            Console.WriteLine(request2);
        }
    }
}
