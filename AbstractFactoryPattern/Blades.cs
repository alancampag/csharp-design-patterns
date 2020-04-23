using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    class Blades : IFlyingMechanism
    {
        public void TakeOff()
        {
            Console.WriteLine("The blades started spinning...");
        }
    }
}
