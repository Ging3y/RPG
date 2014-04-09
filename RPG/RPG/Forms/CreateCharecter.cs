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
        bool formState;


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
         
            //Form Validation
            validateForm();
            if (formState == true)
            {
                getFormValues();
                sendInfoMessage();
                this.Hide();
            }

            //Launch Point distribution
            Forms.PointDistribute pointForm = new Forms.PointDistribute();
            pointForm.Show();
           
        }

        #endregion

        #region Form Validation
        public void validateForm()
        {
            //Handles name
            if (String.IsNullOrEmpty(TextBox_name.Text) ||
             TextBox_name.Text[0] == ' ')
            {
                MessageBox.Show("Your name is empty!");
                formState = false;
            }
            //Gender not an issue, male is default selected
            else if (String.IsNullOrEmpty(ComboBox_type.Text))
            {
                MessageBox.Show("You don't have a type selected!");
                formState = false;
            }
            else
            {
                formState = true;
            }
        }
        #endregion

     
    }
}
