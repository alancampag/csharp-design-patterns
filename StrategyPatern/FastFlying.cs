using System;

namespace StrategyPattern
{
    class FastFlying : IFlyingBehavior
    {
        public void Fly()
        {
            Console.WriteLine($"Flying fast");
        }
    }
}
