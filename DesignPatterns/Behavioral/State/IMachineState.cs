using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    public interface IMachineState
    {
        void SelectItem(VendingMachine machine, string item);
        void InsertMoney(VendingMachine machine, double amount);
        void DispenseItem(VendingMachine machine);
    }
}
