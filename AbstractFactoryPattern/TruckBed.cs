using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class TruckBed : ICargoMechanism
    {
        public void Load()
        {
            Console.WriteLine("Filling up the truck bed...");
        }
    }
}
