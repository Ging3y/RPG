using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Lumberjack : Entity
    {
        // LUMBERJACK
        // The secret weapon. He is both stronger and healthier than normal

        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region

        #region default Construc
        public Lumberjack()
            : base()
        {
        
        }
        #endregion

        #region Construc overload - name & gender
        public Lumberjack(string name, EntityGender gender)
            : base()
        {
            _name = name;
            _strengthModifier = rand.Next(3, 5);
            _healthModifier = rand.Next(2, 4);
        }
        #endregion

        #region Construc overload - name & gender and stats
        public Lumberjack(string name, EntityGender gender, int strength, int dextirity, int wisdom, int health)
        {
            _name = name;
            _gender = gender;
            _strength = strength;
            _dextirity = dextirity;
            _wisdom = wisdom;
            _health = health;
        }
        #endregion

        #endregion

        #region Method Region
        #endregion

        #region Virtual Method region
        #endregion

    }
}
