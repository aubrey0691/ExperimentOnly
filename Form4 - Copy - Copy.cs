using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data.PostgreSql;
using Microsoft.Office.Interop.Excel;


namespace ExperimentOnly
{
    public partial class OverallLogbookDataB : Form
    {
        public OverallLogbookDataB()
        {
            InitializeComponent();
        }

        private void Changebutt_Click(object sender, EventArgs e)
        {
            ChangePass f1 = new ChangePass();
            f1.Show();
            this.Hide();
        }

        private void Addbutt_Click(object sender, EventArgs e)
        {
            addlog f1 = new addlog();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OverallLogbookDataB fm = new OverallLogbookDataB();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Do you want to logout?";
            string title = "Logout Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                AdminLogin lg = new AdminLogin();
                lg.Show();
                this.Hide();
            }
            else
            {
                OverallLogbookDataB fm = new OverallLogbookDataB();
                fm.Show();
                this.Hide();
            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LogbookDataB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet5.overalldt' table. You can move, or remove it, as needed.
           
            string connectionString = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;"; 
            PgSqlConnection connection = null;
            PgSqlDataReader reader = null;
            try
            {
                connection = new PgSqlConnection(connectionString);
                connection.Open();

                string stm = " SELECT * FROM logbookdt";
                PgSqlDataAdapter dataAdapter = new PgSqlDataAdapter();
                dataAdapter.SelectCommand = new PgSqlCommand(stm, connection);
                DataSet table = new DataSet();
                dataAdapter.Fill(table);
                
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (connection != null)
                    connection.Close();
            }

            this.overalldtTableAdapter.Fill(this.loginDataSet5.overalldt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete f1 = new Delete();
            f1.Show();
            this.Hide();

        }

        private void Internbutt_Click(object sender, EventArgs e)
        {
            LogbookDataB f4 = new LogbookDataB();
            f4.Show();
            this.Hide();
        }

        private void Guestbutt_Click(object sender, EventArgs e)
        {
            GuestLogbookDataB gdt = new GuestLogbookDataB();
            gdt.Show();
            this.Hide();
        }
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void Clearbutt_Click(object sender, EventArgs e)
        {
            string message = "Do you want to clear the table data?";
            string title = "Clear Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //Create SqlConnection
                    PgSqlConnection con = new PgSqlConnection(cs);
                    PgSqlCommand cmd = new PgSqlCommand("Delete from overalldt", con);

                    con.Open();
                    PgSqlDataAdapter adapt = new PgSqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    //If count is equal to 1, than show frmMain form
                    if (count == 1)
                    {
                        MessageBox.Show("Delete Successful!");
                        LogbookDataB fm = new LogbookDataB();
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Delete Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                LogbookDataB fm; fm = new LogbookDataB();
                fm.Show();
                this.Hide();
            }

            
        }

        private void overalldtDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
