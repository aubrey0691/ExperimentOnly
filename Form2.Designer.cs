﻿namespace ExperimentOnly
{
    partial class LogDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogDetails));
            this.GroupLogDeets = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Affiliationbox = new System.Windows.Forms.TextBox();
            this.EmailAddbox = new System.Windows.Forms.TextBox();
            this.TimeOut = new System.Windows.Forms.RadioButton();
            this.TimeIn = new System.Windows.Forms.RadioButton();
            this.Purpose = new System.Windows.Forms.TextBox();
            this.FirstNamebox = new System.Windows.Forms.TextBox();
            this.LastNamebox = new System.Windows.Forms.TextBox();
            this.LogBookIcon = new System.Windows.Forms.PictureBox();
            this.GroupLogDeets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogBookIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupLogDeets
            // 
            this.GroupLogDeets.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogDeets.Controls.Add(this.SubmitButton);
            this.GroupLogDeets.Controls.Add(this.Affiliationbox);
            this.GroupLogDeets.Controls.Add(this.EmailAddbox);
            this.GroupLogDeets.Controls.Add(this.TimeOut);
            this.GroupLogDeets.Controls.Add(this.TimeIn);
            this.GroupLogDeets.Controls.Add(this.Purpose);
            this.GroupLogDeets.Controls.Add(this.FirstNamebox);
            this.GroupLogDeets.Controls.Add(this.LastNamebox);
            this.GroupLogDeets.Location = new System.Drawing.Point(95, 347);
            this.GroupLogDeets.Name = "GroupLogDeets";
            this.GroupLogDeets.Size = new System.Drawing.Size(476, 274);
            this.GroupLogDeets.TabIndex = 0;
            this.GroupLogDeets.TabStop = false;
            this.GroupLogDeets.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(176, 186);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(118, 42);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Affiliationbox
            // 
            this.Affiliationbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affiliationbox.Location = new System.Drawing.Point(52, 145);
            this.Affiliationbox.Name = "Affiliationbox";
            this.Affiliationbox.Size = new System.Drawing.Size(369, 26);
            this.Affiliationbox.TabIndex = 7;
            this.Affiliationbox.Text = "Affiliation";
            this.Affiliationbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EmailAddbox
            // 
            this.EmailAddbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddbox.Location = new System.Drawing.Point(52, 113);
            this.EmailAddbox.Name = "EmailAddbox";
            this.EmailAddbox.Size = new System.Drawing.Size(369, 26);
            this.EmailAddbox.TabIndex = 5;
            this.EmailAddbox.Text = "E-mail Address";
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSize = true;
            this.TimeOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut.Location = new System.Drawing.Point(283, 83);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(89, 24);
            this.TimeOut.TabIndex = 4;
            this.TimeOut.TabStop = true;
            this.TimeOut.Text = "Time Out";
            this.TimeOut.UseVisualStyleBackColor = true;
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSize = true;
            this.TimeIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Location = new System.Drawing.Point(86, 83);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(76, 24);
            this.TimeIn.TabIndex = 3;
            this.TimeIn.TabStop = true;
            this.TimeIn.Text = "Time In";
            this.TimeIn.UseVisualStyleBackColor = true;
            // 
            // Purpose
            // 
            this.Purpose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purpose.Location = new System.Drawing.Point(52, 51);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(369, 26);
            this.Purpose.TabIndex = 2;
            this.Purpose.Text = "Purpose";
            this.Purpose.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FirstNamebox
            // 
            this.FirstNamebox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamebox.Location = new System.Drawing.Point(249, 19);
            this.FirstNamebox.Name = "FirstNamebox";
            this.FirstNamebox.Size = new System.Drawing.Size(172, 26);
            this.FirstNamebox.TabIndex = 1;
            this.FirstNamebox.Text = "First Name";
            // 
            // LastNamebox
            // 
            this.LastNamebox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamebox.Location = new System.Drawing.Point(52, 19);
            this.LastNamebox.Name = "LastNamebox";
            this.LastNamebox.Size = new System.Drawing.Size(172, 26);
            this.LastNamebox.TabIndex = 0;
            this.LastNamebox.Text = "Last Name";
            this.LastNamebox.TextChanged += new System.EventHandler(this.LastNamebox_TextChanged);
            // 
            // LogBookIcon
            // 
            this.LogBookIcon.BackColor = System.Drawing.Color.Transparent;
            this.LogBookIcon.Image = ((System.Drawing.Image)(resources.GetObject("LogBookIcon.Image")));
            this.LogBookIcon.Location = new System.Drawing.Point(197, 81);
            this.LogBookIcon.Name = "LogBookIcon";
            this.LogBookIcon.Size = new System.Drawing.Size(374, 110);
            this.LogBookIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogBookIcon.TabIndex = 1;
            this.LogBookIcon.TabStop = false;
            // 
            // LogDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.LogBookIcon);
            this.Controls.Add(this.GroupLogDeets);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1240, 720);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "LogDetails";
            this.Text = "Guest/Intern Log";
            this.Load += new System.EventHandler(this.LogDetails_Load);
            this.GroupLogDeets.ResumeLayout(false);
            this.GroupLogDeets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogBookIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupLogDeets;
        private System.Windows.Forms.TextBox FirstNamebox;
        private System.Windows.Forms.TextBox LastNamebox;
        private System.Windows.Forms.TextBox Purpose;
        private System.Windows.Forms.RadioButton TimeOut;
        private System.Windows.Forms.RadioButton TimeIn;
        private System.Windows.Forms.TextBox Affiliationbox;
        private System.Windows.Forms.TextBox EmailAddbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.PictureBox LogBookIcon;
    }
}