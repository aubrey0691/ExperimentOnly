using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExperimentOnly
{
    public partial class LogDetails : Form
    {
        public LogDetails()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //group box container
        }

        private void LastNamebox_TextChanged(object sender, EventArgs e)
        {
            LastNamebox.Text = String.Empty;
        }

        private void Purposebox_TextChanged(object sender, EventArgs e)
        {
            Purposebox.Text = String.Empty;
        }

        private void Affiliationbox_TextChanged(object sender, EventArgs e)
        {
            Affiliationbox.Text = String.Empty;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //Log Book Page (form 2) closes and details are recorded in the database.
            string connetionString = null;
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
            }

        }

        private void LogDetails_Load(object sender, EventArgs e)
        {

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

        private void FirstNamebox_TextChanged(object sender, EventArgs e)
        {
            FirstNamebox.Text = String.Empty;
        }

        private void EmailAddbox_TextChanged(object sender, EventArgs e)
        {
            EmailAddbox.Text = String.Empty;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            LastNamebox.Clear();
            FirstNamebox.Clear();
            Purposebox.Clear();
            Affiliationbox.Clear();
            EmailAddbox.Clear();
        }

        private void TimeOut_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
