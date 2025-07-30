namespace RealProblems.ParkingLot
{
    public class TruckFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string licensePlate)
        {
            return new Truck(licensePlate);
        }
    }
}