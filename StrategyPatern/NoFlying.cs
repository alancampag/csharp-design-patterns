using System;

namespace StrategyPattern
{
    class NoFlying : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine($"Can't fly");
        }
    }
}
