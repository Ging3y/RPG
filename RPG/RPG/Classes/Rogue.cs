using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    class Rogue : Entity
    {
        // ROGUE
        // Not as smart, yet very strong. Brute force is his strong point

        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region
        
        #region default Construc
        //Paramerterless Constructer
        public Rogue()
            : base()
        {
        }
        #endregion

        #region Overload construc - Name and Gender
        public Rogue(string name, EntityGender gender)
            : base()
        {
            Name = name;
            Gender = gender;
            _strengthModifier = rand.Next(3, 8);
        }
        #endregion

        #region Overload Construc - Name, gender and stats
        public Rogue(string name, EntityGender gender, int strength, int dextirity, int wisdom, int health)
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
