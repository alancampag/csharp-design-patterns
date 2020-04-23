using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            IVehicleFactory vehicleFactoryOne = new LandVehicleFactory();
            Truck truck = (Truck)vehicleFactoryOne.GetVehicle("truck");
            truck.Start();
            truck.Load();

            IVehicleFactory vehicleFactoryTwo = new AirVehicleFactory();
            Chopper chopper = (Chopper)vehicleFactoryTwo.GetVehicle("chopper");
            chopper.Start();
            chopper.TakeOff();
        }
    }
}
