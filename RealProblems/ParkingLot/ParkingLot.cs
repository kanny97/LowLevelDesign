using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class ParkingLot : IParkingLotPublisher
    {
        private static ParkingLot instance;
        private readonly List<ParkingLevel> parkingLevels;
        private static readonly object instanceLock = new object();
        private readonly object levelsLock = new object();
        private IParkingStrategy parkingStrategy = new FirstAvailableParkingStrategy();
        private readonly List<EntryPoint> entryPoints;
        private readonly List<ExitPoint> exitPoints;
        private readonly List<IParkingLotObserver> observers = new List<IParkingLotObserver>();

        private ParkingLot()
        {
            parkingLevels = new List<ParkingLevel>();
            entryPoints = new List<EntryPoint>();
            exitPoints = new List<ExitPoint>();
        }

        public void AddObserver(IParkingLotObserver observer)
        {
            lock (levelsLock)
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IParkingLotObserver observer)
        {
            lock (levelsLock)
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers(string message)
        {
            lock (levelsLock)
            {
                foreach (var observer in observers)
                {
                    observer.Notify(message);
                }
            }
        }

        public void AddEntryPoint(EntryPoint entryPoint)
        {
            lock (levelsLock)
            {
                entryPoints.Add(entryPoint);
            }
        }

        public void AddExitPoint(ExitPoint exitPoint)
        {
            lock (levelsLock)
            {
                exitPoints.Add(exitPoint);
            }
        }

        public IEnumerable<EntryPoint> GetEntryPoints()
        {
            lock (levelsLock)
            {
                return entryPoints.ToList();
            }
        }

        public IEnumerable<ExitPoint> GetExitPoints()
        {
            lock (levelsLock)
            {
                return exitPoints.ToList();
            }
        }

        public void SetParkingStrategy(IParkingStrategy strategy)
        {
            lock (levelsLock)
            {
                parkingStrategy = strategy;
            }
        }

        //Singleton pattern to get single instance of parking lot
        public static ParkingLot GetParkingLotInstance()
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new ParkingLot();
                }
                return instance;
            }
        }

        public bool ParkVehicle(Vehicle vehicle, EntryPoint entryPoint)
        {
            string vehicleType = vehicle.GetVehicleType().ToString();
            //Use entry point data for logging or validation if needed
            Console.WriteLine($"Entry Point ID: {entryPoint.Id}");

            lock (levelsLock)
            {
                //Use the parking strategy to find a suitable level
                ParkingSpot? parkingSpot;
                parkingSpot = parkingStrategy.FindParkingSpot(parkingLevels, vehicle);
                if (parkingSpot != null)
                {
                    // If a suitable parking spot is found, park the vehicle
                    parkingSpot.ParkVehicle(vehicle);
                    Console.WriteLine($"{vehicleType} parked successfully at spot {parkingSpot.GetId()}");
                    NotifyObservers($"{vehicleType} parked successfully at spot {parkingSpot.GetId()}");
                    return true;
                }
            }
            Console.WriteLine($"{vehicleType} couldn't be parked");
            NotifyObservers($"{vehicleType} couldn't be parked");
            return false;
        }

        public bool UnparkVehicle(Vehicle vehicle, ExitPoint exitPoint)
        {
            string vehicleType = vehicle.GetVehicleType().ToString();
            //Use exit point data for logging or validation if needed
            Console.WriteLine($"Exit Point ID: {exitPoint.Id}");
            lock (levelsLock)
            {
                foreach (var level in parkingLevels)
                {
                    if (level.UnparkVehicle(vehicle))
                    {
                        Console.WriteLine($"{vehicleType} unparked successfully");
                        NotifyObservers($"{vehicleType} unparked successfully");
                        return true;
                    }
                }
            }
            Console.WriteLine($"{vehicleType} couldn't be unparked");
            NotifyObservers($"{vehicleType} couldn't be unparked");
            return false;
        }

        public void AddLevel(ParkingLevel level)
        {
            parkingLevels.Add(level);
        }

        public void DisplayAvailability()
        {
            lock (levelsLock)
            {
                foreach (var level in parkingLevels)
                {
                    level.DisplayAvailability();
                }
            }
        }
    }
}
