using System;

namespace StrategyPattern
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        readonly IFlyingBehavior flyingBehavior;

        public Animal(string name, int legs, IFlyingBehavior flyingBehavior)
        {
            Name = name;
            Legs = legs;
            this.flyingBehavior = flyingBehavior;
        }

        public void Walk()
        {
            Console.WriteLine($"The {Name} walks with it's {Legs} legs");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} makes noise");
        }

        public void Fly()
        {
            this.flyingBehavior.Fly(this);
        }

    }
}

