using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class FastFlying : IFlyingBehavior
    {
        public void Fly(Animal animal)
        {
            Console.WriteLine($"{animal.Name} flies fast");
        }
    }
}
