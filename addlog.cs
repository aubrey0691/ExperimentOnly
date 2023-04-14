using Devart.Data.PostgreSql;
using Google.Protobuf;
using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExperimentOnly
{
    public partial class addlog : Form
    {
        PgSqlConnection con = new PgSqlConnection();
        PgSqlCommand command = new PgSqlCommand();
        string n1;
        int rm;
        Datalayer dl;
        public addlog()
        {
            dl = new Datalayer();
            InitializeComponent();
        }
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void LogbookFormLabel_Click(object sender, EventArgs e)
        {

        }
       
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create SqlConnection
                PgSqlConnection con = new PgSqlConnection(cs);
                PgSqlCommand cmd = new PgSqlCommand("insert into alldt(date,time,user_type,time_state,honorifics,first_name,middle_initial,last_name,purpose,email,affiliation) values (@date, @time, @user_type,  @time_state, @honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con);
                DateTime aDate = this.dateTimePicker1.Value.Date;
                DateTime aTime = this.dateTimePicker2.Value;
                aDate.ToString("MM/dd/yyyy");
                aTime.ToString("HH:mm:ss");
                string scolor = "";
                if (TimeOut.Checked)
                {
                    scolor = TimeOut.Text;
                }

                if (TimeIn.Checked)
                {
                    scolor = TimeIn.Text;
                }

                cmd.Parameters.AddWithValue("@date", aDate);
                cmd.Parameters.AddWithValue("@time", aTime);
                cmd.Parameters.AddWithValue("@user_type", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@time_state", scolor);
                cmd.Parameters.AddWithValue("@honorifics", Honorificsbox.Text);
                cmd.Parameters.AddWithValue("@first_name", FirstNamebox.Text);
                cmd.Parameters.AddWithValue("@middle_initial", MiddleInitialbox.Text);
                cmd.Parameters.AddWithValue("@last_name", LastNamebox.Text);
                cmd.Parameters.AddWithValue("@purpose", Purposebox.Text);
                cmd.Parameters.AddWithValue("@email", EmailAddbox.Text);
                cmd.Parameters.AddWithValue("@affiliation", Affiliationbox.Text);
                con.Open();
                PgSqlDataAdapter adapt = new PgSqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Successful!");

                }
                else
                {
                    MessageBox.Show("Log Added!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void TimeIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TimeOut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Honorificsbox.Clear();
            FirstNamebox.Clear();
            MiddleInitialbox.Clear();
            LastNamebox.Clear();
            Purposebox.Clear();
            Affiliationbox.Clear();
            EmailAddbox.Clear();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LogbookDataB fm = new LogbookDataB();
            fm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
           
                
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Honorificsbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FirstNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MiddleInitialbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purposebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailAddbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Affiliationbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm:ss";
            dateTimePicker2.ShowUpDown = true;
        }
    }
}
