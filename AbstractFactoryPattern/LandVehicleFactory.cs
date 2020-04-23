using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AbstractFactoryPattern
{
    class LandVehicleFactory : IVehicleFactory
    {
        public Vehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "car":
                    return new Car(this);

                case "truck":
                    return new Truck(this);

                default:
                    return null;
            }
        }

        public ICargoMechanism AddCargoMechanism()
        {
            return new TruckBed();
        }
    }
}
