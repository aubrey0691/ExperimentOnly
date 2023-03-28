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
            // TODO: This line of code loads data into the 'logbookDataSet1.logbookdata' table. You can move, or remove it, as needed.this.logbookdataTableAdapter.Fill(this.logbookDataSet1.logbookdata);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
