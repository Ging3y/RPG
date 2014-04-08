using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Using the folder with all classes in it
using RPG.Classes;

namespace RPG.Forms
{
    public partial class CreateCharecter : Form
    {
        string charName, race, gender;

        public CreateCharecter()
        {
            InitializeComponent();
        }

        #region Close Char creation form
        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Getting form info
        public void getFormValues()
        {
            charName = TextBox_name.Text;
            race = ComboBox_type.Text;

            if (RadioButton_male.Checked)
            {
                gender = "Male";
            }

            if (RadioButton_female.Checked)
            {
                gender = "Female";
            }
            if (RadioButton_unknown.Checked)
            {
                gender = "Unknown";
            }
        }
        #endregion

        #region Displaying Info Methods
        public void sendInfoMessage()
        {
            MessageBox.Show("Name: " + charName + "\n\n" + "Type: " +
               race + "\n\n" + "Gender: " + gender, "Creating your charecter");
        }

       
        #endregion

        #region Button Click
        private void Button_showchardata_Click_1(object sender, EventArgs e)
        {
            //Create a mage
            Mage player1 = new Mage();

            MessageBox.Show("You have a new Mage with a strength of " +
                player1.Strength.ToString() + ".", "New Mage.");

            getFormValues();
            sendInfoMessage();
            this.Hide();
        }

        #endregion

    }
}
