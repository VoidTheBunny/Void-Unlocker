﻿namespace VoidUnlocker
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
            this.gradientPanel1 = new VoidUnlocker.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Unlockfps = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XButton
            // 
            this.XButton.BackColor = System.Drawing.Color.Red;
            this.XButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.XButton.FlatAppearance.BorderSize = 0;
            this.XButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XButton.ForeColor = System.Drawing.SystemColors.Control;
            this.XButton.Location = new System.Drawing.Point(993, 1);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(40, 38);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.UseVisualStyleBackColor = false;
            this.XButton.Click += new System.EventHandler(this.XButton_Click);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 0F;
            this.gradientPanel1.BackColor = System.Drawing.Color.Fuchsia;
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.Unlockfps);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1033, 539);
            this.gradientPanel1.TabIndex = 2;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradientPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 76);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Unlockfps
            // 
            this.Unlockfps.BackColor = System.Drawing.Color.White;
            this.Unlockfps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Unlockfps.FlatAppearance.BorderSize = 0;
            this.Unlockfps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unlockfps.Font = new System.Drawing.Font("Monster Friend Fore", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unlockfps.Location = new System.Drawing.Point(12, 484);
            this.Unlockfps.Name = "Unlockfps";
            this.Unlockfps.Size = new System.Drawing.Size(252, 43);
            this.Unlockfps.TabIndex = 1;
            this.Unlockfps.Text = "Unlock FPS";
            this.Unlockfps.UseVisualStyleBackColor = false;
            this.Unlockfps.Click += new System.EventHandler(this.Unlockfps_Click);
            // 
            // guiversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1033, 539);
            this.Controls.Add(this.XButton);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guiversion";
            this.Text = "guiversion";
            this.Load += new System.EventHandler(this.guiversion_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button XButton;
        private System.Windows.Forms.Button Unlockfps;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}