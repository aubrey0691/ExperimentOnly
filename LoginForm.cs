/*using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
public class Login { 
    string connectionString = "server=127.0.0.1;database=lbdatabase;uid=root;port=3307;datasource=127.0.0.1;";
    // Your query,
    string query = "SELECT * FROM user";
    // Prepare the connection
    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
    commandDatabase.CommandTimeout = 60;
    MySqlDataReader reader;
    // Let's do it !
    try
    {
        // Open the database
        databaseConnection.Open();
        // Execute the query
        reader = commandDatabase.ExecuteReader();
        // All succesfully executed, now do something
        // IMPORTANT : 
        // If your query returns result, use the following processor :
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                // Do something with every received database ROW
                string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
            }
        }
        else
        {
            Console.WriteLine("No rows found.");
        }
        // Finally close the connection
        databaseConnection.Close();
    }
    catch (Exception ex)
    {
         // Show any error message.
         MessageBox.Show(ex.Message);
    }*/

/*using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class Login
{
    DataSet ds;
    public Login()
    {
        ds = new DataSet(); 
    }
 
    public string QueryScalar(string Query)
    {
        string str;
        MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
        mySqlConnection.Open();
        
    }
}*/