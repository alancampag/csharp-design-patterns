using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class LandVehicleFactory : IVehicleFactory
    {
        public IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "car":
                    return new Car();

                case "truck":
                    return new Truck();

                default:
                    return null;
            }
        }
    }
}
