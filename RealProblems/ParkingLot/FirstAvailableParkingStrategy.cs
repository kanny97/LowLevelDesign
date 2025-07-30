using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class FirstAvailableParkingStrategy : IParkingStrategy
    {
        public ParkingSpot? FindParkingSpot(IEnumerable<ParkingLevel> parkingLevels, Vehicle vehicle)
        {
            foreach (var level in parkingLevels)
            {
                foreach (var spot in level.GetAvailableParkingSpots(vehicle))
                {
                    return spot;
                }
            }
            //No parking spot found
            return null;
        }
    }
}
