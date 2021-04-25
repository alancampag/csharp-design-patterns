namespace AbstractFactoryPattern
{
    interface ICharacter
    {
        public string Name { get; set; }
        public void Attack(IWeapon weapon);
    }
}
