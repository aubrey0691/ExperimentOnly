namespace ExperimentOnly
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.Intern = new System.Windows.Forms.Button();
            this.Guest = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Intern
            // 
            this.Intern.BackColor = System.Drawing.Color.Transparent;
            this.Intern.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Intern.BackgroundImage")));
            this.Intern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Intern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Intern.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intern.ForeColor = System.Drawing.SystemColors.Window;
            this.Intern.Location = new System.Drawing.Point(172, 354);
            this.Intern.Name = "Intern";
            this.Intern.Size = new System.Drawing.Size(320, 50);
            this.Intern.TabIndex = 0;
            this.Intern.UseVisualStyleBackColor = false;
            this.Intern.Click += new System.EventHandler(this.Intern_Click);
            // 
            // Guest
            // 
            this.Guest.BackColor = System.Drawing.Color.Transparent;
            this.Guest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guest.BackgroundImage")));
            this.Guest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guest.ForeColor = System.Drawing.SystemColors.Window;
            this.Guest.Location = new System.Drawing.Point(172, 444);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(320, 50);
            this.Guest.TabIndex = 1;
            this.Guest.UseVisualStyleBackColor = false;
            this.Guest.Click += new System.EventHandler(this.Guest_Click_3);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.Color.Transparent;
            this.Admin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Admin.BackgroundImage")));
            this.Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.ForeColor = System.Drawing.SystemColors.Window;
            this.Admin.Location = new System.Drawing.Point(172, 535);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(320, 50);
            this.Admin.TabIndex = 2;
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeLabel.Location = new System.Drawing.Point(191, 82);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(348, 77);
            this.WelcomeLabel.TabIndex = 12;
            this.WelcomeLabel.Text = "Welcome!";
            this.WelcomeLabel.Click += new System.EventHandler(this.LogbookFormLabel_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.Intern);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1240, 720);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Intern;
        private System.Windows.Forms.Button Guest;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

