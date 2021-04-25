using System;

namespace AbstractFactoryPattern
{
    class Bow : IWeapon
    {
        private readonly int damage;
        public Bow(int damage)
        {
            this.damage = damage;
        }
        public void DealDamage(ICharacter attacker)
        {
            Console.WriteLine($"{attacker.Name} deals {this.damage} damage with bow");
        }
    }
}