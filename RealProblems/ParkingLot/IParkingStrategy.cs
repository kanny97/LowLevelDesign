using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public interface IParkingStrategy
    {
        ParkingSpot? FindParkingSpot(IEnumerable<ParkingLevel> parkingLevels, Vehicle vehicle);
    }
}
