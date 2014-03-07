namespace RPG.Forms
{
    partial class CreateCharecter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_name = new System.Windows.Forms.Label();
            this.Label_gender = new System.Windows.Forms.Label();
            this.RadioButton_male = new System.Windows.Forms.RadioButton();
            this.RadioButton_female = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RadioButton_unknown = new System.Windows.Forms.RadioButton();
            this.TextBox_name = new System.Windows.Forms.TextBox();
            this.ComboBox_type = new System.Windows.Forms.ComboBox();
            this.Label_type = new System.Windows.Forms.Label();
            this.Button_showchardata = new System.Windows.Forms.Button();
            this.Button_cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(12, 26);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(55, 20);
            this.Label_name.TabIndex = 0;
            this.Label_name.Text = "Name:";
            // 
            // Label_gender
            // 
            this.Label_gender.AutoSize = true;
            this.Label_gender.Location = new System.Drawing.Point(310, 26);
            this.Label_gender.Name = "Label_gender";
            this.Label_gender.Size = new System.Drawing.Size(63, 20);
            this.Label_gender.TabIndex = 1;
            this.Label_gender.Text = "Gender";
            // 
            // RadioButton_male
            // 
            this.RadioButton_male.AutoSize = true;
            this.RadioButton_male.Location = new System.Drawing.Point(3, 3);
            this.RadioButton_male.Name = "RadioButton_male";
            this.RadioButton_male.Size = new System.Drawing.Size(68, 24);
            this.RadioButton_male.TabIndex = 2;
            this.RadioButton_male.TabStop = true;
            this.RadioButton_male.Text = "Male";
            this.RadioButton_male.UseVisualStyleBackColor = true;
            // 
            // RadioButton_female
            // 
            this.RadioButton_female.AutoSize = true;
            this.RadioButton_female.Location = new System.Drawing.Point(3, 33);
            this.RadioButton_female.Name = "RadioButton_female";
            this.RadioButton_female.Size = new System.Drawing.Size(87, 24);
            this.RadioButton_female.TabIndex = 3;
            this.RadioButton_female.TabStop = true;
            this.RadioButton_female.Text = "Female";
            this.RadioButton_female.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_male);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_female);
            this.flowLayoutPanel1.Controls.Add(this.RadioButton_unknown);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(314, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(132, 98);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // RadioButton_unknown
            // 
            this.RadioButton_unknown.AutoSize = true;
            this.RadioButton_unknown.Location = new System.Drawing.Point(3, 63);
            this.RadioButton_unknown.Name = "RadioButton_unknown";
            this.RadioButton_unknown.Size = new System.Drawing.Size(101, 24);
            this.RadioButton_unknown.TabIndex = 4;
            this.RadioButton_unknown.TabStop = true;
            this.RadioButton_unknown.Text = "Unknown";
            this.RadioButton_unknown.UseVisualStyleBackColor = true;
            // 
            // TextBox_name
            // 
            this.TextBox_name.Location = new System.Drawing.Point(73, 23);
            this.TextBox_name.Name = "TextBox_name";
            this.TextBox_name.Size = new System.Drawing.Size(231, 26);
            this.TextBox_name.TabIndex = 5;
            // 
            // ComboBox_type
            // 
            this.ComboBox_type.FormattingEnabled = true;
            this.ComboBox_type.Items.AddRange(new object[] {
            "Cleric ",
            "Lumberjack",
            "Mage",
            "Paladin",
            "Rogue"});
            this.ComboBox_type.Location = new System.Drawing.Point(73, 119);
            this.ComboBox_type.Name = "ComboBox_type";
            this.ComboBox_type.Size = new System.Drawing.Size(231, 28);
            this.ComboBox_type.TabIndex = 6;
            // 
            // Label_type
            // 
            this.Label_type.AutoSize = true;
            this.Label_type.Location = new System.Drawing.Point(12, 122);
            this.Label_type.Name = "Label_type";
            this.Label_type.Size = new System.Drawing.Size(47, 20);
            this.Label_type.TabIndex = 7;
            this.Label_type.Text = "Type:";
            // 
            // Button_showchardata
            // 
            this.Button_showchardata.Location = new System.Drawing.Point(61, 300);
            this.Button_showchardata.Name = "Button_showchardata";
            this.Button_showchardata.Size = new System.Drawing.Size(159, 85);
            this.Button_showchardata.TabIndex = 8;
            this.Button_showchardata.Text = "Save Charecter";
            this.Button_showchardata.UseVisualStyleBackColor = true;
            this.Button_showchardata.Click += new System.EventHandler(this.Button_showchardata_Click_1);
            // 
            // Button_cancel
            // 
            this.Button_cancel.Location = new System.Drawing.Point(245, 300);
            this.Button_cancel.Name = "Button_cancel";
            this.Button_cancel.Size = new System.Drawing.Size(159, 85);
            this.Button_cancel.TabIndex = 9;
            this.Button_cancel.Text = "Cancel";
            this.Button_cancel.UseVisualStyleBackColor = true;
            this.Button_cancel.Click += new System.EventHandler(this.Button_cancel_Click);
            // 
            // CreateCharecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 424);
            this.Controls.Add(this.Button_cancel);
            this.Controls.Add(this.Button_showchardata);
            this.Controls.Add(this.Label_type);
            this.Controls.Add(this.ComboBox_type);
            this.Controls.Add(this.TextBox_name);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Label_gender);
            this.Controls.Add(this.Label_name);
            this.Name = "CreateCharecter";
            this.Text = "CreateCharecter";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.Label Label_gender;
        private System.Windows.Forms.RadioButton RadioButton_male;
        private System.Windows.Forms.RadioButton RadioButton_female;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RadioButton_unknown;
        private System.Windows.Forms.TextBox TextBox_name;
        private System.Windows.Forms.ComboBox ComboBox_type;
        private System.Windows.Forms.Label Label_type;
        private System.Windows.Forms.Button Button_showchardata;
        private System.Windows.Forms.Button Button_cancel;
    }
}