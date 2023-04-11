namespace ExperimentOnly
{
    partial class addlog
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
            this.GroupLogDeets = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FirstNamebox = new System.Windows.Forms.TextBox();
            this.Honorificsbox = new System.Windows.Forms.TextBox();
            this.LastNamebox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.Affiliationbox = new System.Windows.Forms.TextBox();
            this.EmailAddbox = new System.Windows.Forms.TextBox();
            this.Purposebox = new System.Windows.Forms.TextBox();
            this.MiddleInitialbox = new System.Windows.Forms.TextBox();
            this.radioboxgroup = new System.Windows.Forms.GroupBox();
            this.TimeIn = new System.Windows.Forms.RadioButton();
            this.TimeOut = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.GroupLogDeets.SuspendLayout();
            this.radioboxgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupLogDeets
            // 
            this.GroupLogDeets.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogDeets.Controls.Add(this.comboBox1);
            this.GroupLogDeets.Controls.Add(this.FirstNamebox);
            this.GroupLogDeets.Controls.Add(this.Honorificsbox);
            this.GroupLogDeets.Controls.Add(this.LastNamebox);
            this.GroupLogDeets.Controls.Add(this.Clear);
            this.GroupLogDeets.Controls.Add(this.HomeButton);
            this.GroupLogDeets.Controls.Add(this.SubmitButton);
            this.GroupLogDeets.Controls.Add(this.Affiliationbox);
            this.GroupLogDeets.Controls.Add(this.EmailAddbox);
            this.GroupLogDeets.Controls.Add(this.Purposebox);
            this.GroupLogDeets.Controls.Add(this.MiddleInitialbox);
            this.GroupLogDeets.Controls.Add(this.radioboxgroup);
            this.GroupLogDeets.Location = new System.Drawing.Point(135, 394);
            this.GroupLogDeets.Name = "GroupLogDeets";
            this.GroupLogDeets.Size = new System.Drawing.Size(479, 298);
            this.GroupLogDeets.TabIndex = 12;
            this.GroupLogDeets.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Guest",
            "Intern"});
            this.comboBox1.Location = new System.Drawing.Point(171, 4);
            this.comboBox1.MaxDropDownItems = 2;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "User type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FirstNamebox
            // 
            this.FirstNamebox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNamebox.Location = new System.Drawing.Point(249, 40);
            this.FirstNamebox.Name = "FirstNamebox";
            this.FirstNamebox.Size = new System.Drawing.Size(165, 26);
            this.FirstNamebox.TabIndex = 14;
            this.FirstNamebox.Text = "First Name";
            // 
            // Honorificsbox
            // 
            this.Honorificsbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Honorificsbox.Location = new System.Drawing.Point(45, 40);
            this.Honorificsbox.Name = "Honorificsbox";
            this.Honorificsbox.Size = new System.Drawing.Size(165, 26);
            this.Honorificsbox.TabIndex = 13;
            this.Honorificsbox.Text = "Honorifics";
            // 
            // LastNamebox
            // 
            this.LastNamebox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNamebox.Location = new System.Drawing.Point(249, 72);
            this.LastNamebox.Name = "LastNamebox";
            this.LastNamebox.Size = new System.Drawing.Size(165, 26);
            this.LastNamebox.TabIndex = 12;
            this.LastNamebox.Text = "Last Name";
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
            this.Clear.Location = new System.Drawing.Point(110, 239);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 36);
            this.Clear.TabIndex = 11;
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_18;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.Location = new System.Drawing.Point(2, 266);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(32, 27);
            this.HomeButton.TabIndex = 10;
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackgroundImage = global::ExperimentOnly.Properties.Resources.bc2ba4c2_4bbb_4256_b8f3_de88f4c9686a;
            this.SubmitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.Location = new System.Drawing.Point(245, 239);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 36);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // Affiliationbox
            // 
            this.Affiliationbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Affiliationbox.Location = new System.Drawing.Point(45, 198);
            this.Affiliationbox.Name = "Affiliationbox";
            this.Affiliationbox.Size = new System.Drawing.Size(369, 26);
            this.Affiliationbox.TabIndex = 7;
            this.Affiliationbox.Text = "Affiliation";
            // 
            // EmailAddbox
            // 
            this.EmailAddbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddbox.Location = new System.Drawing.Point(45, 166);
            this.EmailAddbox.Name = "EmailAddbox";
            this.EmailAddbox.Size = new System.Drawing.Size(369, 26);
            this.EmailAddbox.TabIndex = 5;
            this.EmailAddbox.Text = "E-mail Address";
            // 
            // Purposebox
            // 
            this.Purposebox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purposebox.Location = new System.Drawing.Point(45, 104);
            this.Purposebox.Name = "Purposebox";
            this.Purposebox.Size = new System.Drawing.Size(369, 26);
            this.Purposebox.TabIndex = 2;
            this.Purposebox.Text = "Purpose";
            // 
            // MiddleInitialbox
            // 
            this.MiddleInitialbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleInitialbox.Location = new System.Drawing.Point(45, 72);
            this.MiddleInitialbox.Name = "MiddleInitialbox";
            this.MiddleInitialbox.Size = new System.Drawing.Size(165, 26);
            this.MiddleInitialbox.TabIndex = 0;
            this.MiddleInitialbox.Text = "Middle Initial";
            // 
            // radioboxgroup
            // 
            this.radioboxgroup.Controls.Add(this.TimeIn);
            this.radioboxgroup.Controls.Add(this.TimeOut);
            this.radioboxgroup.Location = new System.Drawing.Point(45, 127);
            this.radioboxgroup.Name = "radioboxgroup";
            this.radioboxgroup.Size = new System.Drawing.Size(369, 38);
            this.radioboxgroup.TabIndex = 15;
            this.radioboxgroup.TabStop = false;
            // 
            // TimeIn
            // 
            this.TimeIn.AutoSize = true;
            this.TimeIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Location = new System.Drawing.Point(36, 8);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.Size = new System.Drawing.Size(76, 24);
            this.TimeIn.TabIndex = 3;
            this.TimeIn.TabStop = true;
            this.TimeIn.Text = "Time In";
            this.TimeIn.UseVisualStyleBackColor = true;
            this.TimeIn.CheckedChanged += new System.EventHandler(this.TimeIn_CheckedChanged);
            // 
            // TimeOut
            // 
            this.TimeOut.AutoSize = true;
            this.TimeOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut.Location = new System.Drawing.Point(240, 9);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.Size = new System.Drawing.Size(89, 24);
            this.TimeOut.TabIndex = 4;
            this.TimeOut.TabStop = true;
            this.TimeOut.Text = "Time Out";
            this.TimeOut.UseVisualStyleBackColor = true;
            this.TimeOut.CheckedChanged += new System.EventHandler(this.TimeOut_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 364);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(258, 24);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(439, 364);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.WelcomeLabel.Location = new System.Drawing.Point(214, 72);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(321, 77);
            this.WelcomeLabel.TabIndex = 16;
            this.WelcomeLabel.Text = "Add Logs";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // addlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExperimentOnly.Properties.Resources.deda97a5_fd5c_402f_90ee_0f132417dda61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GroupLogDeets);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 750);
            this.MinimumSize = new System.Drawing.Size(800, 750);
            this.Name = "addlog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.GroupLogDeets.ResumeLayout(false);
            this.GroupLogDeets.PerformLayout();
            this.radioboxgroup.ResumeLayout(false);
            this.radioboxgroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GroupLogDeets;
        private System.Windows.Forms.TextBox FirstNamebox;
        private System.Windows.Forms.TextBox Honorificsbox;
        private System.Windows.Forms.TextBox LastNamebox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox Affiliationbox;
        private System.Windows.Forms.TextBox EmailAddbox;
        private System.Windows.Forms.TextBox Purposebox;
        private System.Windows.Forms.TextBox MiddleInitialbox;
        private System.Windows.Forms.GroupBox radioboxgroup;
        private System.Windows.Forms.RadioButton TimeIn;
        private System.Windows.Forms.RadioButton TimeOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}