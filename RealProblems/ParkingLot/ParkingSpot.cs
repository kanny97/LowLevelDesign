using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public class ParkingSpot
    {
        private readonly int id;
        private bool isOccupied;
        private Vehicle? vehicle;
        private readonly VehicleType vehicleType;
        private readonly object _lock = new object();

        public ParkingSpot(int id, VehicleType vehicleType)
        {
            this.id = id;
            this.isOccupied = false;
            this.vehicleType = vehicleType;
        }

        public int GetId()
        {
            return id;
        }

        public bool IsOccupied()
        {
            lock (_lock)
            {
                return isOccupied;
            }
        }

        public Vehicle? GetVehicle()
        {
            lock (_lock)
            {
                return vehicle;
            }
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            lock (_lock)
            {
                if (!isOccupied && this.vehicleType == vehicle.GetVehicleType())
                {
                    this.vehicle = vehicle;
                    isOccupied = true;
                }
                else
                {
                    throw new InvalidOperationException("Parking spot is already occupied or vehicle type mismatch.");
                }
            }
        }

        public void UnparkVehicle()
        {
            lock (_lock)
            {
                if (isOccupied)
                {
                    vehicle = null;
                    isOccupied = false;
                }
                else
                {
                    throw new InvalidOperationException("Parking spot is already empty.");
                }
            }
        }

        public VehicleType GetVehicleType()
        {
            return vehicleType;
        }
        public override string ToString()
        {
            lock (_lock)
            {
                return $"ParkingSpot [ID={id}, VehicleType={vehicleType}, IsOccupied={isOccupied}, Vehicle={vehicle?.ToString() ?? "None"}]";
            }
        }
    }
}
