using System;

namespace AbstractFactoryPattern
{
    class Sword : IWeapon
    {
        private readonly int damage;
        public Sword(int damage)
        {
            this.damage = damage;
        }

        public void DealDamage(ICharacter attacker)
        {
            Console.WriteLine($"{attacker.Name} deals {this.damage} damage with sword");
        }
    }
}
