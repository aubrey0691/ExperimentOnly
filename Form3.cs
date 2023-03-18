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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySqlX.XDevAPI;


namespace ExperimentOnly
{
    
    
    public partial class AdminLogin : Form
    {
        
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void GroupLogDeets_Enter(object sender, EventArgs e)
        {

        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LogDetails f2 = new LogDetails();
            f2.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            runQuery();
        }

        private void runQuery()
        {
            string query = Passwordbox.Text;
            if (query == "")
            {
                MessageBox.Show("Please Enter A Password!");
                return;
            }

            /*string connectionString = "server=127.0.0.1;database=login;uid=root;port=3307";
            var providerName = "System.Data.SqlClient";*/
            SqlConnection con = new SqlConnection(@"server=127.0.0.1;database=login;uid=root;Protocol=pipe;PipeName=mypipename;"); // making connection 

            /*// Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;*/

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM login WHERE password='" + Passwordbox.Text + "'", con);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                /* I have made a new page called home page. If the user is successfully authenticated then the form will be moved to the next form */
                this.Hide();
                new LogbookDataB().Show();
            }
            else
                MessageBox.Show("Invalid username or password");

        }
        /* try
         {
             // Open the database
             databaseConnection.Open();

             // Execute the query
             reader = commandDatabase.ExecuteReader();

             // All succesfully executed, now do something

             // IMPORTANT : 
             // If your query returns result, use the following processor :

             if (reader.HasRows)
             {
                 while (reader.Read())
                 {
                     // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                     // Do something with every received database ROW
                     string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                 }
             }
             else
             {
                 Console.WriteLine("No rows found.");
             }

             // Finally close the connection
             databaseConnection.Close();
         }
         catch (Exception ex)
         {
             // Show any error message.
             MessageBox.Show(ex.Message);
         }
     }*/

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
