using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public enum EntityGender { Male, Female, Unknown };
    public enum EntityClass { Cleric, Lumberjack, Mage, Paladin, Rogue, Unknown };

    public abstract class Entity
    {
        #region Fields Region
        protected string entityType;
        protected EntityGender _gender;
        protected EntityClass _characterclass;
        protected string _name;
        protected int _strength;
        protected int _dextirity;
        protected int _wisdom;
        protected int _health;
        protected int _strengthModifier;
        protected int _dextirityModifier;
        protected int _wisdomModifier;
        protected int _healthModifier;
        #endregion

        #region Properties Region
        public EntityGender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public EntityClass CharacterClass
        {
            get { return _characterclass; }
            set { _characterclass = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            set { _strength = value; }
        }
        public int Dextirity
        {
            get { return _dextirity + _dextirityModifier; }
            set { _dextirity = value; }
        }
        public int Wisdom
        {
            get { return _wisdom + _wisdomModifier; }
            set { _wisdom = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
            set { _health = value; }
        }
        #endregion

        #region Constructors Region
        public Entity()
        {
            //Set initial property values
            Name = " ";
            Gender = EntityGender.Unknown;
            CharacterClass = EntityClass.Unknown;
            Strength = 0;
            Dextirity = 0;
            Wisdom = 0;
            Health = 0;
        }
        #endregion
         
    }
}
