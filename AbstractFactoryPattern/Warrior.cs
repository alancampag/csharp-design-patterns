namespace AbstractFactoryPattern
{
    class Warrior : ICharacter
    {
        public string Name { get; set; }

        public void Attack(IWeapon weapon)
        {
            weapon.DealDamage(this);
        }
    }
}
