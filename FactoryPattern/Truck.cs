using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The truck starts...");
        }
    }
}
