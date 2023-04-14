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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ExperimentOnly
{
    public partial class Delete : Form
    {
        public Delete()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
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

            this.logbookdtTableAdapter.Fill(this.loginDataSet.logbookdt);
        }

        private void IDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;"; ;
            PgSqlConnection connection = null;
            try
            {
                connection = new PgSqlConnection(connectionString);
                connection.Open();
                PgSqlCommand cmd = new PgSqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "delete from alldt where id = @id;";
                cmd.Parameters.AddWithValue("@id", IDbox.Text);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet5.alldt' table. You can move, or remove it, as needed.
            this.alldtTableAdapter.Fill(this.loginDataSet5.alldt);
            // TODO: This line of code loads data into the 'loginDataSet5.logbookdt' table. You can move, or remove it, as needed.
            this.logbookdtTableAdapter2.Fill(this.loginDataSet5.logbookdt);
           
            

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IDbox.Clear();
        }

        private void GroupLogDeets_Enter(object sender, EventArgs e)
        {

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
                    PgSqlCommand cmd = new PgSqlCommand("Delete from alldt" + "ALTER SEQUENCE alldt_id_seq RESTART WITH 1", con);
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
                        MessageBox.Show("Deleted!");
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            LogbookDataB fm = new LogbookDataB();
            fm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Delete f1 = new Delete();
            f1.Show();
            this.Hide();
        }

        private void Addbutt_Click_1(object sender, EventArgs e)
        {
            addlog f1 = new addlog();
            f1.Show();
            this.Hide();
        }

        private void Changebutt_Click_1(object sender, EventArgs e)
        {
            ChangePass f1 = new ChangePass();
            f1.Show();
            this.Hide();
        }
    }
}
