using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    interface ICharacterFactory
    {
        public ICharacter GetCharacter();
        public IWeapon GetWeapon(int damage);
    }
}
