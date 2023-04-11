namespace ExperimentOnly
{
    partial class Delete
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logbookdtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDataSet1 = new ExperimentOnly.loginDataSet();
            this.loginDataSet = new ExperimentOnly.loginDataSet();
            this.logbookdataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logbookdtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logbookdtTableAdapter = new ExperimentOnly.loginDataSetTableAdapters.logbookdtTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timestateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.honorificsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleinitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purposeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logbookdtBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.GroupLogDeets = new System.Windows.Forms.GroupBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.loginDataSet3 = new ExperimentOnly.loginDataSet3();
            this.logbookdtBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.logbookdtTableAdapter1 = new ExperimentOnly.loginDataSet3TableAdapters.logbookdtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource2)).BeginInit();
            this.GroupLogDeets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ExperimentOnly.Properties.Resources._out;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(60, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 37);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ExperimentOnly.Properties.Resources.bin;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(246, 571);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 36);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ExperimentOnly.Properties.Resources.refresh_icon_white_1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(153, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 36);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logbookdtBindingSource1
            // 
            this.logbookdtBindingSource1.DataMember = "logbookdt";
            this.logbookdtBindingSource1.DataSource = this.loginDataSet1;
            // 
            // loginDataSet1
            // 
            this.loginDataSet1.DataSetName = "loginDataSet";
            this.loginDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginDataSet
            // 
            this.loginDataSet.DataSetName = "loginDataSet";
            this.loginDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logbookdtBindingSource
            // 
            this.logbookdtBindingSource.DataMember = "logbookdt";
            this.logbookdtBindingSource.DataSource = this.loginDataSet1;
            // 
            // logbookdtTableAdapter
            // 
            this.logbookdtTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.timestateDataGridViewTextBoxColumn,
            this.honorificsDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middleinitialDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.purposeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.affiliationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logbookdtBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(343, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(881, 585);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // timestateDataGridViewTextBoxColumn
            // 
            this.timestateDataGridViewTextBoxColumn.DataPropertyName = "time_state";
            this.timestateDataGridViewTextBoxColumn.HeaderText = "time_state";
            this.timestateDataGridViewTextBoxColumn.Name = "timestateDataGridViewTextBoxColumn";
            // 
            // honorificsDataGridViewTextBoxColumn
            // 
            this.honorificsDataGridViewTextBoxColumn.DataPropertyName = "honorifics";
            this.honorificsDataGridViewTextBoxColumn.HeaderText = "honorifics";
            this.honorificsDataGridViewTextBoxColumn.Name = "honorificsDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // middleinitialDataGridViewTextBoxColumn
            // 
            this.middleinitialDataGridViewTextBoxColumn.DataPropertyName = "middle_initial";
            this.middleinitialDataGridViewTextBoxColumn.HeaderText = "middle_initial";
            this.middleinitialDataGridViewTextBoxColumn.Name = "middleinitialDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // purposeDataGridViewTextBoxColumn
            // 
            this.purposeDataGridViewTextBoxColumn.DataPropertyName = "purpose";
            this.purposeDataGridViewTextBoxColumn.HeaderText = "purpose";
            this.purposeDataGridViewTextBoxColumn.Name = "purposeDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // affiliationDataGridViewTextBoxColumn
            // 
            this.affiliationDataGridViewTextBoxColumn.DataPropertyName = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.HeaderText = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.Name = "affiliationDataGridViewTextBoxColumn";
            // 
            // logbookdtBindingSource2
            // 
            this.logbookdtBindingSource2.DataMember = "logbookdt";
            this.logbookdtBindingSource2.DataSource = this.loginDataSet1;
            // 
            // GroupLogDeets
            // 
            this.GroupLogDeets.BackColor = System.Drawing.Color.Transparent;
            this.GroupLogDeets.Controls.Add(this.IDbox);
            this.GroupLogDeets.Controls.Add(this.Clear);
            this.GroupLogDeets.Controls.Add(this.HomeButton);
            this.GroupLogDeets.Controls.Add(this.DeleteButton);
            this.GroupLogDeets.Location = new System.Drawing.Point(2, 205);
            this.GroupLogDeets.Name = "GroupLogDeets";
            this.GroupLogDeets.Size = new System.Drawing.Size(342, 271);
            this.GroupLogDeets.TabIndex = 16;
            this.GroupLogDeets.TabStop = false;
            // 
            // IDbox
            // 
            this.IDbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(38, 120);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(261, 26);
            this.IDbox.TabIndex = 13;
            this.IDbox.Text = "ID";
            this.IDbox.TextChanged += new System.EventHandler(this.IDbox_TextChanged);
            // 
            // Clear
            // 
            this.Clear.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_11;
            this.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Clear.Location = new System.Drawing.Point(38, 168);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(89, 28);
            this.Clear.TabIndex = 11;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeButton.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_18;
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.Location = new System.Drawing.Point(0, 244);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(32, 27);
            this.HomeButton.TabIndex = 10;
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = global::ExperimentOnly.Properties.Resources.Asset_11;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteButton.Location = new System.Drawing.Point(210, 168);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(89, 28);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // loginDataSet3
            // 
            this.loginDataSet3.DataSetName = "loginDataSet3";
            this.loginDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logbookdtBindingSource3
            // 
            this.logbookdtBindingSource3.DataMember = "logbookdt";
            this.logbookdtBindingSource3.DataSource = this.loginDataSet3;
            // 
            // logbookdtTableAdapter1
            // 
            this.logbookdtTableAdapter1.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExperimentOnly.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.GroupLogDeets);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1240, 720);
            this.MinimumSize = new System.Drawing.Size(1240, 720);
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource2)).EndInit();
            this.GroupLogDeets.ResumeLayout(false);
            this.GroupLogDeets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logbookdtBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource logbookdataBindingSource;
        private loginDataSet loginDataSet;
        private loginDataSet loginDataSet1;
        private System.Windows.Forms.BindingSource logbookdtBindingSource;
        private loginDataSetTableAdapters.logbookdtTableAdapter logbookdtTableAdapter;
        private System.Windows.Forms.BindingSource logbookdtBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timestateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn honorificsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleinitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purposeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affiliationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource logbookdtBindingSource2;
        private System.Windows.Forms.GroupBox GroupLogDeets;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button DeleteButton;
        private loginDataSet3 loginDataSet3;
        private System.Windows.Forms.BindingSource logbookdtBindingSource3;
        private loginDataSet3TableAdapters.logbookdtTableAdapter logbookdtTableAdapter1;
    }
}