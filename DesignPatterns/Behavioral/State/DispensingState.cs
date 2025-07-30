using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class DispensingState : IMachineState
    {
        public void SelectItem(VendingMachine machine, string item)
        {
            // Implementation for selecting an item in the dispensing state  
            Console.WriteLine("Please wait, dispensing in progress");
        }

        public void InsertMoney(VendingMachine machine, double amount)
        {
            // Implementation for inserting money in the dispensing state  
            Console.WriteLine("Please wait, dispensing in progress");
        }

        public void DispenseItem(VendingMachine machine)
        {
            // Implementation for dispensing an item  
            Console.WriteLine("Already dispensed, please wait!");
        }
    }
}
