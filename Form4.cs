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
using Devart.Data.Linq.Mapping.Fluent;
using System.IO;


namespace ExperimentOnly
{
    public partial class LogbookDataB : Form
    {
        public LogbookDataB()
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
            LogbookDataB fm = new LogbookDataB();
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
                LogbookDataB fm = new LogbookDataB();
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
            // TODO: This line of code loads data into the 'loginDataSet52.alldt' table. You can move, or remove it, as needed.
            this.alldtTableAdapter.Fill(this.loginDataSet52.alldt);
            this.alldtTableAdapter.Fill(this.loginDataSet51.alldt);
           
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

            advancedDataGridView1.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            advancedDataGridView1.Columns[2].DefaultCellStyle.Format = (@"hh\:mm\:ss");
            advancedDataGridView1.RowsDefaultCellStyle.BackColor = Color.MintCream;
            advancedDataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            advancedDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            advancedDataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray;
            advancedDataGridView1.DefaultCellStyle.SelectionForeColor = Color.MintCream;

            advancedDataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            advancedDataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            advancedDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            advancedDataGridView1.AllowUserToResizeColumns = false;

        }


        private void Internbutt_Click(object sender, EventArgs e)
        {
            LogbookDataB f4 = new LogbookDataB();
            f4.Show();
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
                    PgSqlCommand cmd = new PgSqlCommand("Delete from alldt", con);

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

        private void Exportbutt_Click(object sender, EventArgs e)
        {
            if (advancedDataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = advancedDataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[advancedDataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += advancedDataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < advancedDataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += advancedDataGridView1.Rows[i - 1].Cells[j].Value + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }  
}
