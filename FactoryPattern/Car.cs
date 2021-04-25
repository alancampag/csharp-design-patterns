using System;

namespace FactoryMethodPattern
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car starts...");
        }
    }
}
