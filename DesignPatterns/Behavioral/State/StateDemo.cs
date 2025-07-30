using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class StateDemo
    {
        public static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            //Will give error if we do this in idle state
            vendingMachine.DispenseItem();

            //Valid operations
            vendingMachine.SelectItem("ItemCode1");
            vendingMachine.InsertMoney(5);
            vendingMachine.DispenseItem();

            Console.WriteLine("Second transaction");
            vendingMachine.SelectItem("ItemCode2");
            vendingMachine.InsertMoney(10.67);
            vendingMachine.DispenseItem();
        }
    }
}
