using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Cleric : Entity
    {
        // CLERIC 
        // The class that has more health, will not be as aggressive 

        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region

        #region Default Constructor
        public Cleric()
            : base()
        {
           
        }
        #endregion

        #region Constuc overload - name & gender
        //Constructor overload
        public Cleric(string name, EntityGender gender)
            : base()
        {
            _name = name;
            _healthModifier = rand.Next(3, 5);
        }
        #endregion

        #region Constuc overload - name, gender, stats
        public Cleric(string name, EntityGender gender, int strength, int dextirity, int wisdom, int health)
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
