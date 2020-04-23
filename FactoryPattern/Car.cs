using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("The car starts...");
        }
    }
}
