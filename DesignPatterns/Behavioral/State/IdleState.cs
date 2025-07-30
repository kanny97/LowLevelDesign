namespace DesignPatterns.Behavioral.State
{
    public class IdleState : IMachineState
    {
        public void SelectItem(VendingMachine machine, string item)
        {
            // Implementation for selecting an item in IdleState
            Console.WriteLine($"Item '{item}' selected in IdleState.");
            machine.SetSelectedItem(item);
            machine.SetState(new ItemSelectedState());                      
        }

        public void InsertMoney(VendingMachine machine, double amount)
        {
            // Implementation for inserting money in IdleState  
            Console.WriteLine($"We need to select an item before inserting money in IdleState.");
        }

        public void DispenseItem(VendingMachine machine)
        {
            // Implementation for dispensing an item in IdleState
            Console.WriteLine($"Cannot dispense item in IdleState.");
        }
    }
}