namespace AbstractFactoryPattern
{
    class RangedCharacterFactory : ICharacterFactory
    {
        public ICharacter GetCharacter()
        {
            return new Archer();
        }

        public IWeapon GetWeapon(int damage)
        {
            return new Bow(damage);
        }
    }
}
