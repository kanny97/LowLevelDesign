using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealProblems.ParkingLot
{
    public abstract class Vehicle
    {
        protected string LicensePlate { get; set; }
        protected VehicleType Type { get; set; }

        public Vehicle(string licensePlate, VehicleType type)
        {
            LicensePlate = licensePlate;
            Type = type;
        }
        public override string ToString()
        {
            return $"{Type} Vehicle with License Plate: {LicensePlate}";
        }
        public string GetLicensePlate()
        {
            return LicensePlate;
        }
        public VehicleType GetVehicleType()
        {
            return Type;
        }
    }
}
