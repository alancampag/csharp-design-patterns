using System;

namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog(string name, IFlyingBehavior flyingBehavior) : base(name, flyingBehavior) { }
    }
}
