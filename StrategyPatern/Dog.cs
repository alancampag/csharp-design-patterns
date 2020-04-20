using System;

namespace StrategyPattern
{
    public class Dog : Animal
    {
        public Dog(string name, int legs, IFlyingBehavior flyingBehavior) : base(name, legs, flyingBehavior)
        {
        }

        public new void Speak()
        {
            Console.WriteLine($"{Name} says: bark, bark");
        }
    }
}
