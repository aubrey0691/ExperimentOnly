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
using System.Xml.Linq;
using Npgsql;
using Devart.Data.PostgreSql;
using System.Data.OleDb;

namespace ExperimentOnly
{
    public partial class ChangePass : Form
    {
        Datalayer dl;
        public ChangePass()
        {
            dl = new Datalayer();
            InitializeComponent();
        }
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void button1_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            if (Passwordbox.Text == "")
            {
                MessageBox.Show("Please provide a Password");
                return;
            }
            try
            {
                //Create SqlConnection
                PgSqlConnection con= new PgSqlConnection(cs);
                con.Open();
                PgSqlCommand cmd = new PgSqlCommand("update user set password='"+NewPasswordbox.Text+"' where username='admin'", con);
                PgSqlDataAdapter adapt = new PgSqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Change Successful!");
                    LogbookDataB fm = new LogbookDataB();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Change Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    

        private void Passwordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPasswordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmPasswordbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            LogbookDataB fm = new LogbookDataB();
            fm.Show();
            this.Hide();
        }
    }
}
