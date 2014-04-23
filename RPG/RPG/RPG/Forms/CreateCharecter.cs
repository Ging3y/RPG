using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG.Forms
{
    public partial class CreateCharecter : Form
    {
        public CreateCharecter()
        {
            InitializeComponent();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        string charName, race, gender;


        #region Getting char info
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

        private void Button_showchardata_Click_1(object sender, EventArgs e)
        {
            getFormValues();
            sendInfoMessage();
            this.Hide();
        }
        #endregion


        private void exitButton_Click(object sender, EventArgs e)
        {
            //Make sure not to use .Close();
            //It crashes the program when you try to 
            //reopen the window
            this.Hide();
        }

   
    }
}
