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
using Mysqlx.Datatypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace ExperimentOnly
{
    public partial class GuestLogDetails : Form
    {
        PgSqlConnection con = new PgSqlConnection();
        PgSqlCommand command = new PgSqlCommand();
        string n1;
        int rm;
        Datalayer dl;
        public GuestLogDetails()
        {
            dl = new Datalayer();
            InitializeComponent();
        }
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //group box container
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create SqlConnection
                PgSqlConnection con = new PgSqlConnection(cs);
                PgSqlCommand cmd = new PgSqlCommand("insert into guestlogdt(date,time,time_state,honorifics,first_name,middle_initial,last_name,purpose,email,affiliation) values (@date, @time, @time_state, @honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con);
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

            /*string constr = @"server=127.0.0.1;port=5432;user = postgres;password=root;Database=login;";
            PgSqlConnection con = new PgSqlConnection(constr);
            con.Open();
            PgSqlCommand cmd = new PgSqlCommand("insert into logbookdata(time_state,honorifics,first_name,middle_initial,last_name,purpose,email,affiliation) values (@time_state, @honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@time_state", "test");
                    cmd.Parameters.AddWithValue("@honorifics", Honorificsbox.Text);
                    cmd.Parameters.AddWithValue("@first_name", FirstNamebox.Text);
                    cmd.Parameters.AddWithValue("@middle_initial", MiddleInitialbox.Text);
                    cmd.Parameters.AddWithValue("@last_name", LastNamebox.Text);
                    cmd.Parameters.AddWithValue("@purpose", Purposebox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailAddbox.Text);
                    cmd.Parameters.AddWithValue("@affiliation", Affiliationbox.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();*/

        }

        public static void main(string[] args)
        {

            

        }

        private void LogDetails_Load(object sender, EventArgs e)
        {
            PgSqlConnection con = new PgSqlConnection("User Id=postgres;Database=login;Port=5432;Initial Schema=public;password=root;Integrated Security=True");
            
        }
        
        private void GetDate(object sender, EventArgs e)
        {
            DateTime aDate = DateTime.Now;

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
            
        }

        private void TimeIn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void Check(string radioName)
        {
            
            
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
