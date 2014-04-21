namespace RPG
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Button_createchar = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_createchar
            // 
            this.Button_createchar.BackColor = System.Drawing.SystemColors.Control;
            this.Button_createchar.Location = new System.Drawing.Point(31, 415);
            this.Button_createchar.Name = "Button_createchar";
            this.Button_createchar.Size = new System.Drawing.Size(169, 63);
            this.Button_createchar.TabIndex = 0;
            this.Button_createchar.Text = "Create Charecter ";
            this.Button_createchar.UseVisualStyleBackColor = false;
            this.Button_createchar.Click += new System.EventHandler(this.Button_createchar_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.BackColor = System.Drawing.SystemColors.Control;
            this.Button_exit.Location = new System.Drawing.Point(31, 493);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(169, 63);
            this.Button_exit.TabIndex = 1;
            this.Button_exit.Text = "Quit";
            this.Button_exit.UseVisualStyleBackColor = false;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 584);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Button_createchar);
            this.MaximumSize = new System.Drawing.Size(900, 640);
            this.MinimumSize = new System.Drawing.Size(900, 640);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG - Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_createchar;
        private System.Windows.Forms.Button Button_exit;
    }
}

