using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Lumberjack : Entity
    {
        //Create random # generator
        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region
        public Lumberjack()
            : base()
        {
            _strength = rand.Next(3, 5);
            _health = rand.Next(2, 4);
        }

        //Constructor overload
        public Lumberjack(string name, EntityGender gender)
            : base()
        {
            _strength = rand.Next(3, 5);
            _health = rand.Next(2, 4);
        }
        //Constructor Overload (If user is allowed to provide values - like from a pool of points)
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

        #region Method Region
        #endregion

        #region Virtual Method region
        #endregion
         
    }
}
