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

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.Logbook' table. You can move, or remove it, as needed.
            this.logbookTableAdapter1.Fill(this.loginDataSet.Logbook);
            // TODO: This line of code loads data into the 'logbookDataSet.Logbook' table. You can move, or remove it, as needed.
            this.logbookTableAdapter.Fill(this.logbookDataSet.Logbook);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
