using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classses
{
    public enum Entitygender { Male, Female, Unknown };

    public abstract class Entity
    {
        #region Fields Region
        protected string _name;
        protected Entitygender _gender;
        protected int _strength;
        protected int _dextirity;
        protected int _wisdom;
        protected int _health;
        protected int _strengthModifier;
        protected int _dextirityModifier;
        protected int _wisdomModifer;
        protected int _healthModifer;
#endregion

        #region Properties Region
       
        #endregion

        #region Constructors Region
        #endregion

    }
}
