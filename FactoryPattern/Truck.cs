using System;

namespace FactoryMethodPattern
{
    class Truck : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The truck starts...");
        }
    }
}
