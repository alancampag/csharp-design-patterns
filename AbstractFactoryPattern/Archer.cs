namespace AbstractFactoryPattern
{
    class Archer : ICharacter
    {
        public string Name { get; set; }

        public void Attack(IWeapon weapon)
        {
            weapon.DealDamage(this);
        }
    }
}
