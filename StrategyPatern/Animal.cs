using System;

namespace StrategyPattern
{
    public class Animal
    {
        public string Name { get; set; }
        public IFlyingBehavior FlyingBehavior { get; set; }

        public Animal(string name, IFlyingBehavior flyingBehavior)
        {
            Name = name;
            FlyingBehavior = flyingBehavior;
        }

        public void Fly()
        {
            FlyingBehavior.Fly();
        }

    }
}

