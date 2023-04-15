using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct.Library.Settings;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Devart.Data.PostgreSql;




namespace ExperimentOnly
{
    
    
    public partial class AdminLogin : Form
    {
        Datalayer dl;
        public AdminLogin()
        {
            dl = new Datalayer();
            InitializeComponent();
        }

        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";

        private void GroupLogDeets_Enter(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LandingPage f1 = new LandingPage();
            f1.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //input admin password which was saved in the database table users and checks if passwords match before logging in successfully
            if (Passwordbox.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                PgSqlConnection con = new PgSqlConnection(cs);
                PgSqlCommand cmd = new PgSqlCommand("Select * from users where password=@password", con);
                
                cmd.Parameters.AddWithValue("@password", Passwordbox.Text);
                con.Open();
                PgSqlDataAdapter adapt = new PgSqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    LogbookDataB fm = new LogbookDataB();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PgSqlConnection con = new PgSqlConnection("User Id=postgres;Database=login;Port=5432;Initial Schema=public;password=root;Initial Catalog=login;Integrated Security=True");
            con.Open();
        }
        
        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //clear input value
            Passwordbox.Clear();
        }

        private void Usernamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            //button redirects back to the landing page (form 1)
            LandingPage f1 = new LandingPage();
            f1.Show();
            this.Hide();
        }
    }
    
}
