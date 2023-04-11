using Devart.Data.PostgreSql;
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
                PgSqlCommand cmd = new PgSqlCommand("insert into logbookdt(date,time,time_state,honorifics,first_name,middle_initial,last_name,purpose,email,affiliation) values (@date, @time, @time_state, @honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con);
                DateTime aDate = DateTime.Now;
                DateTime aTime = DateTime.Now;
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
                cmd.Parameters.AddWithValue("@time_state", scolor);
                cmd.Parameters.AddWithValue("@time_state", n1);
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
                    MessageBox.Show("Failed!");
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
    }
}
