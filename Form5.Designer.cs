namespace ExperimentOnly
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.NewPasswordbox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passwordbox
            // 
            this.Passwordbox.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.Passwordbox.Location = new System.Drawing.Point(196, 280);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.Size = new System.Drawing.Size(393, 40);
            this.Passwordbox.TabIndex = 8;
            this.Passwordbox.Text = "Password";
            this.Passwordbox.UseSystemPasswordChar = true;
            this.Passwordbox.TextChanged += new System.EventHandler(this.Passwordbox_TextChanged);
            // 
            // NewPasswordbox
            // 
            this.NewPasswordbox.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.NewPasswordbox.Location = new System.Drawing.Point(196, 350);
            this.NewPasswordbox.Name = "NewPasswordbox";
            this.NewPasswordbox.Size = new System.Drawing.Size(393, 40);
            this.NewPasswordbox.TabIndex = 9;
            this.NewPasswordbox.Text = "Password";
            this.NewPasswordbox.UseSystemPasswordChar = true;
            this.NewPasswordbox.TextChanged += new System.EventHandler(this.NewPasswordbox_TextChanged);
            // 
            // ConfirmPasswordbox
            // 
            this.ConfirmPasswordbox.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.ConfirmPasswordbox.Location = new System.Drawing.Point(196, 419);
            this.ConfirmPasswordbox.Name = "ConfirmPasswordbox";
            this.ConfirmPasswordbox.Size = new System.Drawing.Size(393, 40);
            this.ConfirmPasswordbox.TabIndex = 10;
            this.ConfirmPasswordbox.Text = "Password";
            this.ConfirmPasswordbox.UseSystemPasswordChar = true;
            this.ConfirmPasswordbox.TextChanged += new System.EventHandler(this.ConfirmPasswordbox_TextChanged);
            this.ConfirmPasswordbox.Validated += new System.EventHandler(this.NewPasswordbox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_11;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(270, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 43);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_17;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(765, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConfirmPasswordbox);
            this.Controls.Add(this.NewPasswordbox);
            this.Controls.Add(this.Passwordbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.TextBox NewPasswordbox;
        private System.Windows.Forms.TextBox ConfirmPasswordbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}