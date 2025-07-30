using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class CarFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string licensePlate)
        {
            return new Car(licensePlate);
        }
    }
}
