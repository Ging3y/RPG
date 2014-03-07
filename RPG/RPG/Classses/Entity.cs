using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classses
{
    public enum EntityGender { Male, Female, Unknown };

    public abstract class Entity
    {
        #region Fields Region
        protected string entityType;
        protected EntityGender _gender;

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
            protected set { _gender = value; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int Strength
        {
            get { return _strength + _strengthModifier; }
            protected set { _strength = value; }
        }
        public int Dextirity
        {
            get { return _dextirity + _dextirityModifier; }
            protected set { _dextirity = value; }
        }
        public int Wisdom
        {
            get { return _wisdom + _wisdomModifier; }
            protected set { _wisdom = value; }
        }
        public int Health
        {
            get { return _health + _healthModifier; }
            protected set { _health = value; }
        }

        #endregion

        #region Constructors Region
        public Entity()
        {
            //Set initial property values
            Strength = 0;
            Dextirity = 0;
            Wisdom = 0;
            Health = 0;
        }
        #endregion
         
    }
}
