using System;

namespace StrategyPattern
{
    public class Bird : Animal
    {
        public Bird(string name, int legs, IFlyingBehavior flyingBehavior) : base(name, legs, flyingBehavior)
        {
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name} says: pew, pew");
        }
    }
}
