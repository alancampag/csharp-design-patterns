using System;

namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird(string name, IFlyingBehavior flyingBehavior) : base(name, flyingBehavior) { }
    }
}
