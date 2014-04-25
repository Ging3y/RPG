﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

//Using the folder with all classes in it
using RPG.Classes;

namespace RPG.Forms
{
    public partial class CreateCharecter : Form
    {
        #region Settings Folder
        private static string SettingsFolder
        {
            get
            {
                string folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);
                //adding a sub folder
                folder = Path.Combine(folder, "RPGProject");
                folder = Path.Combine(folder, "Settings");
                //Make sure folder exists
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;

            }
        }
        #endregion

        #region Settingsfile
        private static string SettingsFile
        {
            get
            {
                return Path.Combine(SettingsFolder, "player.xml");
            }
        }
        #endregion

       
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

     

        #region Button Click
        private void Button_showchardata_Click_1(object sender, EventArgs e)
        {
            string name;

            if (String.IsNullOrEmpty(TextBox_name.Text) ||
                TextBox_name.Text[0] == ' ')
            {
                MessageBox.Show("You must name your character. " +
                    "Note also: names cannot begin with a space");
                return;
            }
            name = this.TextBox_name.Text;

            //Check gender
            EntityGender eGender = new EntityGender();
            eGender = EntityGender.Unknown;
            if (this.RadioButton_male.Checked)
                eGender = EntityGender.Male;
            else if (this.RadioButton_female.Checked)
                eGender = EntityGender.Female;
            else
            {
                MessageBox.Show("You must select a gender.");
                return;
            }

            //Check Class
            EntityClass eClass;
            eClass = EntityClass.Unknown;
            if (this.ComboBox_type.Text == "Mage")
                eClass = EntityClass.Mage;
            else if (this.ComboBox_type.Text == "Rogue")
                eClass = EntityClass.Rogue;
            else if (this.ComboBox_type.Text == "Cleric")
                eClass = EntityClass.Cleric;
            else if (this.ComboBox_type.Text == "Paladin")
                eClass = EntityClass.Paladin;
            else if (this.ComboBox_type.Text == "Lumberjack")
                eClass = EntityClass.Lumberjack;
            else
            {
                MessageBox.Show("You must choose a class for your character");
                return;
            }

            //Creat Object
            Player player1 = new Player(name, eGender, eClass);

            MessageBox.Show(player1.ToString(), "Success");






        
         
            //Form Validation
            //validateForm();
            //if (formState == true)
            //{
            //    getFormValues();
            //    sendInfoMessage();
            //    Enter code for saving information here
            //    this.Hide();
            //}
           
        }

        #endregion

        #region Picture Box
        private void ComboBox_type_TextChanged(object sender, EventArgs e)
        {
            if( ComboBox_type.Text == "Cleric")
            {
                PictureBox_char.Image = RPG.Properties.Resources.Cleric;
                PictureBox_char.Refresh();
                PictureBox_char.Visible = true;
            }

            if (ComboBox_type.Text == "Rogue")
            {
                PictureBox_char.Image = RPG.Properties.Resources.Rogue;
                PictureBox_char.Refresh();
                PictureBox_char.Visible = true;
            }

            if (ComboBox_type.Text == "Lumberjack")
            {
                PictureBox_char.Image = RPG.Properties.Resources.Lumberjack;
                PictureBox_char.Refresh();
                PictureBox_char.Visible = true;
            }

            if (ComboBox_type.Text == "Mage")
            {
                PictureBox_char.Image = RPG.Properties.Resources.Mage;
                PictureBox_char.Refresh();
                PictureBox_char.Visible = true;
            }

            if (ComboBox_type.Text == "Paladin")
            {
                PictureBox_char.Image = RPG.Properties.Resources.Paladin;
                PictureBox_char.Refresh();
                PictureBox_char.Visible = true;
            }

        }

        #endregion


        



    }
}
