using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data;
using Devart.Data.PostgreSql;



namespace ExperimentOnly
{
    public partial class LogbookDataB : Form
    {
        public LogbookDataB()
        {
            InitializeComponent();
        }

        private void Database_Load(object sender, EventArgs e)
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

        }

        private void LogbookDataB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet3.logbookdt' table. You can move, or remove it, as needed.
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

            this.logbookdtTableAdapter1.Fill(this.loginDataSet3.logbookdt);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete f1 = new Delete();
            f1.Show();
            this.Hide();

        }

        private void Clearbutt_Click(object sender, EventArgs e)
        {
            string message = "Do you want to clear the data?";
            string title = "Clear Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
                PgSqlConnection con = new PgSqlConnection(cs);
                PgSqlCommand cmd = new PgSqlCommand("DELETE from logbookdt", con);
                con.Open();
                PgSqlDataAdapter adapt = new PgSqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
            }
            else
            {
                this.Close();
            }
        }
       
        private void Exportbutt_Click(object sender, EventArgs e)
        {
          
        }

        private void Internbutt_Click(object sender, EventArgs e)
        {

        }

        private void Guestbutt_Click(object sender, EventArgs e)
        {

        }
    }
}
