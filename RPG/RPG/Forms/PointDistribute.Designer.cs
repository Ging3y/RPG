namespace RPG.Forms
{
    partial class PointDistribute
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
            this.Label_info = new System.Windows.Forms.Label();
            this.Label_head = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_info
            // 
            this.Label_info.AutoSize = true;
            this.Label_info.Location = new System.Drawing.Point(9, 50);
            this.Label_info.Name = "Label_info";
            this.Label_info.Size = new System.Drawing.Size(382, 60);
            this.Label_info.TabIndex = 0;
            this.Label_info.Text = "Welcome to charecter selection, you are now able to \r\ndistribute the remaining po" +
    "ints to create your custom \r\ncharecter.";
            this.Label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_head
            // 
            this.Label_head.AutoSize = true;
            this.Label_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_head.Location = new System.Drawing.Point(63, 9);
            this.Label_head.Name = "Label_head";
            this.Label_head.Size = new System.Drawing.Size(279, 32);
            this.Label_head.TabIndex = 1;
            this.Label_head.Text = "Charecter Stat Sheet";
            // 
            // PointDistribute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 471);
            this.Controls.Add(this.Label_head);
            this.Controls.Add(this.Label_info);
            this.Name = "PointDistribute";
            this.Text = "Point Distribution";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_info;
        private System.Windows.Forms.Label Label_head;
    }
}