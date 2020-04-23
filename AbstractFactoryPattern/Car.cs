using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Car : Vehicle
    {
        public Car(LandVehicleFactory vehicleFactory)
        {
        }

        public override void Start()
        {
            Console.WriteLine("The car starts...");
        }
    }
}
