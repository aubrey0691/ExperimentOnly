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