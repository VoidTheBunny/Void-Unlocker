namespace VoidUnlocker
{
    partial class guiversion
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
            this.XButton = new System.Windows.Forms.Button();
            this.Unlockfps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.ForeColor = System.Drawing.SystemColors.Control;
            this.XButton.Location = new System.Drawing.Point(993, 1);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(40, 38);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // Unlockfps
            // 
            this.Unlockfps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Unlockfps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unlockfps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unlockfps.Location = new System.Drawing.Point(12, 489);
            this.Unlockfps.Name = "Unlockfps";
            this.Unlockfps.Size = new System.Drawing.Size(162, 38);
            this.Unlockfps.TabIndex = 1;
            this.Unlockfps.Text = "Unlock FPS";
            this.Unlockfps.UseVisualStyleBackColor = true;
            this.Unlockfps.Click += new System.EventHandler(this.Unlockfps_Click);
            // 
            // guiversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1033, 539);
            this.Controls.Add(this.Unlockfps);
            this.Controls.Add(this.XButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guiversion";
            this.Text = "guiversion";
            this.Load += new System.EventHandler(this.guiversion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button Unlockfps;
    }
}