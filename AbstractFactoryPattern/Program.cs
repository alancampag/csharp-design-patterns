namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            // the factory is reponsible for creating a family of related objects
            ICharacterFactory characterFactory;

            characterFactory = new MeleeCharacterFactory();

            // in this case, we can get characters and weapons
            ICharacter warrior = characterFactory.GetCharacter();
            warrior.Name = "Warrior";
            IWeapon sword = characterFactory.GetWeapon(42);
            // since they came from the same factory, we can trust they work together
            warrior.Attack(sword);

            // multiple factories can fulfill the same contract
            characterFactory = new RangedCharacterFactory();

            // the objects created will still make sense together
            ICharacter archer = characterFactory.GetCharacter();
            archer.Name = "Archer";
            IWeapon bow = characterFactory.GetWeapon(25);
            archer.Attack(bow);
        }
    }
}
