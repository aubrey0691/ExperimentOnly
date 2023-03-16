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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Guest_Click_3(object sender, EventArgs e)
        {
            LogDetails f2 = new LogDetails();
            f2.Show();
            this.Hide();
        }

        private void Intern_Click(object sender, EventArgs e)
        {
            //Landing page(form1) Intern button opens the Intern Log Book Page(form2) upon clicking
            
            LogDetails f2 = new LogDetails();
            f2.Show();
            this.Hide();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            AdminLogin f3 = new AdminLogin();
            f3.Show();
            this.Hide();
        }

        private void LogbookFormLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
