using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class ParkingLotDemo
    {
        public static void Run()
        {
            ParkingLot parkingLot = ParkingLot.GetParkingLotInstance();

            //Add multiple levels of parking to the parking lot
            ParkingLevel parkingLevel1 = new ParkingLevel(1, 5);
            ParkingLevel parkingLevel2 = new ParkingLevel(2, 10);
            EntryPoint entryPoint1 = new EntryPoint(1);
            EntryPoint entryPoint2 = new EntryPoint(2);
            ExitPoint exitPoint1 = new ExitPoint(1);
            IParkingLotObserver parkingLotObserver = new ParkingLotDisplayObserver();

            parkingLot.AddLevel(parkingLevel1);
            parkingLot.AddLevel(parkingLevel2);
            
            parkingLot.AddObserver(parkingLotObserver);

            parkingLot.AddEntryPoint(entryPoint1);
            parkingLot.AddEntryPoint(entryPoint2);
            parkingLot.AddExitPoint(exitPoint1);

            //If we want we can set some other strategy also
            //parkingLot.SetParkingStrategy(new FirstAvailableParkingStrategy());

            parkingLot.DisplayAvailability();

            // Change the type of carFactory from IVehicleFactory to CarFactory
            CarFactory carFactory = new CarFactory();
            Vehicle car = carFactory.CreateVehicle("Lic 123");

            TruckFactory truckFactory = new TruckFactory();
            Vehicle truck = truckFactory.CreateVehicle("Lic 456");

            BikeFactory bikeFactory = new BikeFactory();
            Vehicle bike = bikeFactory.CreateVehicle("Lic 789");

            parkingLot.ParkVehicle(car, entryPoint1);
            parkingLot.ParkVehicle(truck, entryPoint2);
            parkingLot.ParkVehicle(bike, entryPoint1);

            parkingLot.DisplayAvailability();

            parkingLot.UnparkVehicle(car, exitPoint1);
            parkingLot.UnparkVehicle(bike, exitPoint1);

            parkingLot.DisplayAvailability();
        }
    }
}
