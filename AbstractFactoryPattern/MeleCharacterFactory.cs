namespace AbstractFactoryPattern
{
    class MeleeCharacterFactory : ICharacterFactory
    {
        public ICharacter GetCharacter()
        {
            return new Warrior();
        }

        public IWeapon GetWeapon(int damage)
        {
            return new Sword(damage);
        }
    }
}
