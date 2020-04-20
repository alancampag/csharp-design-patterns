using System;

namespace StrategyPatern
{
    public class Animal
    {
        public string Name { get; set; }
        public int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        public void Walk()
        {
            Console.WriteLine($"The {Name} walks with it's {Legs} legs");
        }

        public void Speak()
        {
            Console.WriteLine($"{Name} makes noise");
        }
    }
}

