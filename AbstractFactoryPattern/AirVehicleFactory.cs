using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AbstractFactoryPattern
{
    class AirVehicleFactory : IVehicleFactory
    {
        public Vehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType)
            {
                case "chopper":
                    return new Chopper(this);

                default:
                    return null;
            }
        }

        public IFlyingMechanism AddFlyingMechanism()
        {
            return new Blades();
        }
    }
}
