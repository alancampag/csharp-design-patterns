using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main()
        {
            IVehicleFactory vehicleFactory = new LandVehicleFactory();
            IVehicle vehicle = vehicleFactory.GetVehicle("car");
            vehicle.Start();
        }
    }
}
