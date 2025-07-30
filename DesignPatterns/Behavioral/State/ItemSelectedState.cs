using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class ItemSelectedState : IMachineState
    {
        public void SelectItem(VendingMachine machine, string item)
        {
            // Implementation for selecting an item  
            Console.WriteLine($"Item already selected {machine.GetSelectedItem()}");
        }

        public void InsertMoney(VendingMachine machine, double amount)
        {
            // Implementation for inserting money
            Console.WriteLine($"{amount} inserted for buying item : {machine.GetSelectedItem()}");
            machine.SetInsertedMoney(amount);
            machine.SetState(new HasMoneyState());
        }

        public void DispenseItem(VendingMachine machine)
        {
            // Implementation for dispensing an item  
            Console.WriteLine("Can't dispense in selected state, insert money");
        }
    }
}
