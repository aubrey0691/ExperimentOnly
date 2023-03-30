using Devart.Data.PostgreSql;
using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExperimentOnly
{
    public partial class addlog : Form
    {
        public addlog()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=127.0.0.1; Database = login; Uid = postgres; Password = root; Persist Security Info = True;";
        private void LogbookFormLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string honor = Honorificsbox.Text, fname = FirstNamebox.Text, middlein = MiddleInitialbox.Text, lname = LastNamebox.Text, purpose = Purposebox.Text, email = EmailAddbox.Text, aff = Affiliationbox.Text;
            PgSqlConnection con = new PgSqlConnection(cs);
            
            //DateTime inputdate = DateTime.Parse(dateTimePicker1.Text);
            // if (RadioButton.Checked == true) { timestate = "Male"; } else { timestate = "Female"; }
            con.Open();
            PgSqlCommand cmd = new PgSqlCommand("INSERT INTO logbookdata '" + honor + "','" + fname +"','" + middlein + "', '" + lname +"','" + purpose + "','" + email +"','" + aff + "'", con);
            MessageBox.Show("Successfully added");
        }

        private void TimeIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TimeOut_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
