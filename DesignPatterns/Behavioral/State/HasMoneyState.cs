using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class HasMoneyState : IMachineState
    {
        public void SelectItem(VendingMachine machine, string item)
        {
            // Implement logic for selecting an item when the machine has money
            Console.WriteLine("Cannot change item after inserting money");
        }

        public void InsertMoney(VendingMachine machine, double amount)
        {
            // Implement logic for inserting money when the machine already has money  
            Console.WriteLine("Already money is inserted into the machine");
        }

        public void DispenseItem(VendingMachine machine)
        {
            // Implement logic for dispensing an item when the machine has money  
            Console.WriteLine($"Dispensing {machine.GetSelectedItem()} of amount : {machine.GetInsertedMoney()}");            
            machine.SetState(new DispensingState());
            //Simulate some activity for 1second
            Thread.Sleep(1000);
            Console.WriteLine("Item dispensed successfully");
            machine.ResetMachine();
        }
    }
}
