namespace RealProblems.ParkingLot
{
    public class BikeFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string licensePlate)
        {
            return new Bike(licensePlate);
        }
    }
}