using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Truck : Vehicle
    {
        public Truck(LandVehicleFactory vehicleFactory)
        {
            this.cargoMechanism = vehicleFactory.AddCargoMechanism();
        }

        public override void Start()
        {
            Console.WriteLine("The truck starts...");
        }

        public void Load()
        {
            this.cargoMechanism.Load();
        }
    }
}
