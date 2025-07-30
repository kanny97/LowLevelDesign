using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class ParkingLevel
    {
        private readonly int levelNumber;
        private readonly List<ParkingSpot> parkingSpots;
        private readonly object _lock = new object();

        public ParkingLevel(int levelNumber, int numSpots)
        {
            this.levelNumber = levelNumber;
            parkingSpots = new List<ParkingSpot>();

            double spotsForBikes = 0.5;
            double spotsForCars = 0.4;

            int numBikes = (int)(numSpots * spotsForBikes);
            int numCars = (int)(numSpots * spotsForCars);

            for (int i = 1; i <= numBikes; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.BIKE));
            }
            for (int i = numBikes + 1; i <= numCars + numBikes; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.CAR));
            }
            for (int i = numCars + numBikes + 1; i <= numSpots; i++)
            {
                parkingSpots.Add(new ParkingSpot(i, VehicleType.TRUCK));
            }
        }
        public IEnumerable<ParkingSpot> GetAvailableParkingSpots(Vehicle vehicle)
        {
            lock (_lock)
            {
                return parkingSpots.Where(x => !x.IsOccupied() && x.GetVehicleType() == vehicle.GetVehicleType()).ToList();
            }            
        }
        public bool ParkVehicle(Vehicle vehicle)
        {
            lock (_lock)
            {
                foreach (var parkingSpot in parkingSpots)
                {
                    if (!parkingSpot.IsOccupied() && parkingSpot.GetVehicleType() == vehicle.GetVehicleType())
                    {
                        parkingSpot.ParkVehicle(vehicle);
                        return true;
                    }
                }
                return false;
            }
        }

        public bool UnparkVehicle(Vehicle vehicle)
        {
            lock (_lock)
            {
                foreach (var parkingSpot in parkingSpots)
                {
                    if (parkingSpot.IsOccupied() && parkingSpot.GetVehicle() != null && parkingSpot.GetVehicle().Equals(vehicle))
                    {
                        parkingSpot.UnparkVehicle();
                        return true;
                    }
                }
                return false;
            }
        }

        public int GetLevelNumber()
        {
            return this.levelNumber;
        }

        public void DisplayAvailability()
        {
            lock (_lock)
            {
                Console.WriteLine($"Level {levelNumber} availability");
                foreach (var parkingSpot in parkingSpots)
                {
                    Console.WriteLine($"Spot {parkingSpot.GetId()} : {(parkingSpot.IsOccupied() ? "is occupied by" : "is available for ")} {parkingSpot.GetVehicleType()}");
                }
            }
        }
    }
}
