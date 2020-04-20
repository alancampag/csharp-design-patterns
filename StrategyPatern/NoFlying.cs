using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class NoFlying : IFlyingBehavior
    {
        public void Fly(Animal animal)
        {
            Console.WriteLine($"{animal.Name} can't fly");
        }
    }
}
