using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class ParkingLotDisplayObserver : IParkingLotObserver
    {
        public void Notify(string message)
        {
            // Display the message on the parking lot display
            Console.WriteLine($"Parking Lot Display: {message}");
        }
    }
}
