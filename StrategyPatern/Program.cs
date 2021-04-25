using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main()
        {
            // flying behavior is independent of animal class
            Animal doggo = new Dog("Doggo", new NoFlying());
            doggo.Fly();

            Animal birdo = new Bird("Birdo", new FastFlying());
            birdo.Fly();

            // changing behavior at runtime, dog can now fly
            doggo.FlyingBehavior = new FastFlying();
            doggo.Fly();
        }
    }
}
