using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class Truck : Vehicle
    {
        public Truck(string licensePlate) : base(licensePlate, VehicleType.TRUCK) { }
    }
}