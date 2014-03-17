using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Classes
{
    public class Mage : Entity
    {
        Random rand = new Random();

        #region Field Region
        #endregion

        #region Property Region
        #endregion

        #region Constructor Region
        //Paramerterless Constructer
        public Mage()
            : base()
        {
        }

        //Overload
        public Mage(string name, EntityGender gender)
            : base()
        {
            Name = name;
            Gender = gender;
            //TODO: Add formulas based on class
            _wisdomModifier = rand.Next(3, 8);
        }
        #endregion

        #region Method Region
        #endregion

        #region Virtual Method region
        #endregion
 
    }
}
