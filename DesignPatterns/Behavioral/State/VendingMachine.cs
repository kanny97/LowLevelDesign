using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public class VendingMachine
    {
        private IMachineState currentState;
        private string selectedItem;
        private double insertedMoney;
        public VendingMachine()
        {
            // Initialize the vending machine in the idle state
            currentState = new IdleState();
            selectedItem = "";
            Console.WriteLine("Vending machine initialized in idle state.");
        }
        public void SetState(IMachineState state)
        {
            currentState = state;
            Console.WriteLine($"Vending machine state changed to: {state.GetType().Name}");
        }
        public void SelectItem(string item)
        {
            currentState.SelectItem(this, item);
        }
        public string GetSelectedItem()
        {
            return selectedItem;
        }
        public void SetSelectedItem(string item)
        {
            selectedItem = item;
        }
        public void InsertMoney(double amount)
        {
            currentState.InsertMoney(this, amount);
        }
        public void SetInsertedMoney(double amount)
        {
            insertedMoney = amount;
        }
        public double GetInsertedMoney()
        {
            return insertedMoney;
        }
        public void DispenseItem()
        {
            currentState.DispenseItem(this);
        }
        public void ResetMachine()
        {
            selectedItem = "";
            insertedMoney = 0.0;
            SetState(new IdleState());
            Console.WriteLine("Vending machine reset to idle state.");
        }
    }
}
