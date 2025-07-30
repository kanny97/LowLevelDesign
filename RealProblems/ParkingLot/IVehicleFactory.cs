using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public interface IVehicleFactory
    {
        Vehicle CreateVehicle(string licensePlate);
    }
}
