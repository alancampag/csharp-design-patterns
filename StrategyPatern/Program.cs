using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            Animal doggo = new Dog("Doggo", 4, new NoFlying());
            ((Dog)doggo).Fly();

            Animal birdo = new Bird("Birdo", 2, new FastFlying());
            ((Bird)birdo).Fly();
        }
    }
}
