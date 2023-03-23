using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NpgsqlTypes;
using Devart.Data.PostgreSql;

namespace ExperimentOnly
{
    public partial class LogDetails : Form
    {
        string n1;
        public LogDetails()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //group box container
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Log Book Page (form 2) closes and details are recorded in the database.
           /* string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=127.0.0.1;database=lbdatabase;uid=root;port=3307;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }*/
            string constr = @"server=127.0.0.1;port=5432;user = postgres;password=root;Database=login;";
            
            using (PgSqlConnection con = new PgSqlConnection(constr))
            {
                using (PgSqlCommand cmd = new PgSqlCommand("INSERT INTO Logbook(First Name, Middle Initial, Last Name, Time in/Time out, Purpose, Email, Affiliation) " +
                    "VALUES(@honorifics, @firstname, @middleinitial, @lastname, @timeinout, @purpose, @email, @affiliation)"))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@honorifics", Honorificsbox.Text);
                    cmd.Parameters.AddWithValue("@firstname", FirstNamebox.Text);
                    cmd.Parameters.AddWithValue("@middleinitial", MiddleInitialbox.Text);
                    cmd.Parameters.AddWithValue("@lastname", LastNamebox.Text);
                    cmd.Parameters.AddWithValue("@timeinout", n1);
                    cmd.Parameters.AddWithValue("@purpose", Purposebox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailAddbox.Text);
                    cmd.Parameters.AddWithValue("@affiliation", Affiliationbox.Text);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();
                } 

            }


        }

        public static void main(string[] args)
        {

            

        }

        private void LogDetails_Load(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LandingPage f1 = new LandingPage();
            f1.Show();
            this.Hide();
        }

        private void LogbookFormlabel_Click(object sender, EventArgs e)
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

        private void radioboxgroup_Enter(object sender, EventArgs e)
        {

        }

        private void TimeOut_CheckedChanged(object sender, EventArgs e)
        {
            var radioFired = (RadioButton)sender;
            Check(radioFired.Name);
        }

        private void TimeIn_CheckedChanged(object sender, EventArgs e)
        {
            var radioFired = (RadioButton)sender;
            Check(radioFired.Name);
        }

        public void Check(string radioName)
        {
            
            switch (radioName)
            {
                case "radio1a":
                    n1 = "Time in";
                    break;
                case "radio1b":
                    n1 = "Time out";
                    break; 
         }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

     

        
    }
}
