namespace ExperimentOnly
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.GroupLogDeets = new System.Windows.Forms.GroupBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Passwordbox = new System.Windows.Forms.TextBox();
            this.GroupLogDeets.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(172, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // GroupLogDeets
            // 
            this.GroupLogDeets.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogDeets.Controls.Add(this.HomeButton);
            this.GroupLogDeets.Controls.Add(this.Clear);
            this.GroupLogDeets.Controls.Add(this.AdminLabel);
            this.GroupLogDeets.Controls.Add(this.SubmitButton);
            this.GroupLogDeets.Controls.Add(this.Passwordbox);
            this.GroupLogDeets.Location = new System.Drawing.Point(94, 348);
            this.GroupLogDeets.Name = "GroupLogDeets";
            this.GroupLogDeets.Size = new System.Drawing.Size(476, 274);
            this.GroupLogDeets.TabIndex = 1;
            this.GroupLogDeets.TabStop = false;
            this.GroupLogDeets.Enter += new System.EventHandler(this.GroupLogDeets_Enter);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImage = global::ExperimentOnly.Properties.Resources._23b37693_a35c_4e9a_90fc_c07ffe8176841;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(185, 133);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(97, 32);
            this.HomeButton.TabIndex = 12;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // Clear
            // 
            this.Clear.BackgroundImage = global::ExperimentOnly.Properties.Resources._2057fcaa_04ef_4599_86c4_021ae3fc073c;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(47, 133);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(97, 32);
            this.Clear.TabIndex = 11;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel.ForeColor = System.Drawing.Color.Black;
            this.AdminLabel.Location = new System.Drawing.Point(176, 33);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(128, 38);
            this.AdminLabel.TabIndex = 2;
            this.AdminLabel.Text = "Admin ";
            this.AdminLabel.Click += new System.EventHandler(this.AdminLabel_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImage = global::ExperimentOnly.Properties.Resources.bc2ba4c2_4bbb_4256_b8f3_de88f4c9686a1;
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(319, 133);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(97, 32);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Passwordbox
            // 
            this.Passwordbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passwordbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordbox.Location = new System.Drawing.Point(47, 92);
            this.Passwordbox.Name = "Passwordbox";
            this.Passwordbox.Size = new System.Drawing.Size(369, 19);
            this.Passwordbox.TabIndex = 7;
            this.Passwordbox.Text = "Password";
            this.Passwordbox.UseSystemPasswordChar = true;
            this.Passwordbox.TextChanged += new System.EventHandler(this.Passwordbox_TextChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExperimentOnly.Properties.Resources.Flat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.GroupLogDeets);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1240, 720);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.GroupLogDeets.ResumeLayout(false);
            this.GroupLogDeets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GroupLogDeets;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox Passwordbox;
        private System.Windows.Forms.Label AdminLabel;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button HomeButton;
    }
}