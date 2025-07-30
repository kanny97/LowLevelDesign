using DesignPatterns;
using DesignPatterns.Creational.AbstractFactory.Factories;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Behavioral.Iterator;
using DesignPatterns.Behavioral.Observer;
using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Behavioral.ChainOfResponsibility;
using DesignPatterns.Behavioral.State;

class Program
{
    public static void Main(string[] args)
    {
        // Uncomment the following lines to run specific demos
        // NotificationDemo.Main(args);
        // ApplicationDemo.Main(args);
        // BuilderDemo.Main(args);
        // PrototypeDemo.Main(args);
        // PaymentApplication.Main(args);
        // DecoratorDemo.Main(args);
        // IteratorDemo.Main(args);
        //ObserverDemo.Main(args);
        //StrategyDemo.Main(args);
        //ChainOfResponsibilityDemo.Main(args);
        StateDemo.Main(args);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}