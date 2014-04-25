using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Player : Entity
    {
        Random nand = new Random();

        public Player()
            : base()
        {
        }

        public Player(string name, EntityGender eGender, EntityClass eClass)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
        }

        public Player(string name, EntityGender eGender, EntityClass eClass,
            int dexterity, int health, int strength, int wisdom)
            : base()
        {
            Name = name;
            Gender = eGender;
            CharacterClass = eClass;
            _dextirity = dexterity;
            _health = health;
            _strength = strength;
            _wisdom = wisdom;
        }
    }
}
