using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
