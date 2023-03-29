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
using System.ComponentModel.Composition;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Mysqlx.Crud;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Org.BouncyCastle.Utilities;


namespace ExperimentOnly
{
    public partial class LogDetails : Form
    {
        PgSqlConnection con = new PgSqlConnection();
        PgSqlCommand command = new PgSqlCommand();
        string n1;
        int rm;
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
           /* try
            {
                con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Internship\\Documents\\logdatabase.accdb";
                con.Open();
                command = new OleDbCommand("insert into logdata (Time_State,First_Name, Middle_Initial, Last_Name, Purpose, Email, Affiliation)" +
                       "values (@honorifics, @firstname, @middleinitial, @lastname, @timeinout, @purpose, @email, @affiliation)", con);
                rm = command.ExecuteNonQuery();
                MessageBox.Show("Log Inserted!");
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Log Can't Be Inserted!");
            }*/

                //Log Book Page (form 2) closes and details are recorded in the database.
                /*string connetionString = null;
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
                    con.Open();
                    using (PgSqlCommand cmd = new PgSqlCommand("INSERT INTO lbdata(time_state, honorifics, first_name, middle_initial, last_name, purpose, email, affiliation) " +
                        "VALUES(@time_state,@honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con))

                    {
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@time_state", "test");
                        cmd.Parameters.AddWithValue("@honorifics", Honorificsbox.Text);
                        cmd.Parameters.AddWithValue("@first_name", FirstNamebox.Text);
                        cmd.Parameters.AddWithValue("@middle_initial", MiddleInitialbox.Text);
                        cmd.Parameters.AddWithValue("@last_name", LastNamebox.Text);
                        cmd.Parameters.AddWithValue("@purpose", Purposebox.Text);
                        cmd.Parameters.AddWithValue("@email", EmailAddbox.Text);
                        cmd.Parameters.AddWithValue("@affiliation", Affiliationbox.Text);
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
            PgSqlConnection con = new PgSqlConnection("User Id=postgres;Database=login;Port=5432;Initial Schema=public;password=root;Integrated Security=True");
            
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
