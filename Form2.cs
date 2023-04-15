using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Devart.Data.PostgreSql;
using System.ComponentModel.Composition;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Org.BouncyCastle.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;



namespace ExperimentOnly
{
    public partial class LogDetails : Form
    {
        
        public LogDetails()
        {
         
            InitializeComponent();
        }
        //connection string to connect to the postgresql database
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //group box container
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Create PgSqlConnection
                PgSqlConnection con = new PgSqlConnection(cs);
                PgSqlCommand cmd = new PgSqlCommand("insert into alldt(date,time,user_type,time_state,honorifics,first_name,middle_initial,last_name,purpose,email,affiliation) values (@date, @time, @user_type,  @time_state, @honorifics, @first_name, @middle_initial, @last_name, @purpose, @email, @affiliation)", con);
                DateTime aDate = DateTime.Now;
                DateTime aTime = DateTime.Now;
                aDate.ToString("MM/dd/yyyy");
                aTime.ToString("hh:mm:ss.f");
                string scolor = "";
                if (TimeOut.Checked)
                {
                    scolor = TimeOut.Text;
                }

                if (TimeIn.Checked)
                {
                    scolor = TimeIn.Text;
                }
                //input values to the database with text box value and etc
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
                //If count is equal to 1, then show message 
                if (count == 1)
                {
                    MessageBox.Show("Successful!");
                    
                }
                else
                {
                    MessageBox.Show("Submitted!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
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
            // button directs back to the landing page (form 1)
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
            //clear input values 
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
