using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Paladin : Entity
    {
        // PALADIN
        // Average warrior, yet more dexterious than most

        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region
        
        #region default Construc
        //Paramerterless Constructer
        public Paladin()
            : base()
        {
        }
        #endregion

        #region Overload construc - Name and Gender
        public Paladin(string name, EntityGender gender)
            : base()
        {
            _name = name;
            Gender = gender;
            _dextirityModifier = rand.Next(3, 7);
        }
        #endregion

        #region Overload Construc - Name, gender and stats
        public Paladin(string name, EntityGender gender, int strength, int dextirity, int wisdom, int health)
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
