﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        #region Showing charecter creation form
        Forms.CreateCharecter charForm = new Forms.CreateCharecter();
        private void Button_createchar_Click(object sender, EventArgs e)
        {
            //Show creation charecter form
            charForm.Show();
        }
        #endregion

        #region Quit Button
        private void Button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to quit?",
                "RPG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
