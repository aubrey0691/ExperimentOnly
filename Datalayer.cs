using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Devart.Data;
using Devart.Data.PostgreSql;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace ExperimentOnly    
{
    public class Datalayer
    {
        PgSqlCommand cmd_;
        PgSqlConnection conn_;
        PgSqlDataAdapter adptr_;
        PgSqlDataReader reader_;
        DataTable dtable_;
        DataSet dset_;
        public string getmessage { get; set; }
        public Datalayer()
        {
            string cs = "User Id=postgres;Host=localhost;Database=login;Port=5432;Initial Schema=public;password=root;";
            conn_ = new PgSqlConnection(cs);
            cmd_ = new PgSqlCommand();
            dtable_ = new DataTable();
            adptr_ = new PgSqlDataAdapter();
            dset_ = new DataSet();
        }
        public bool connect()
        {
            try
            {
                conn_.Open();
                getmessage = "successfully connected";
                return true;
            }
            catch (Exception ex)
            {
                getmessage = "connection error" + ex.Message;
                return false;
            }
        }
        public bool disconnect()
        {
            try
            {
                conn_.Clone();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string InsertUpdateDeleteCreate(string query)
        {
            string ret = "";
            string allquerys = query.ToLower();
            try
            {
                cmd_.CommandText = query.ToLower();
                cmd_.Connection = conn_;
                connect();
                cmd_.ExecuteNonQuery();
                if (allquerys.ToLower().Contains("insert into"))
                {
                    ret = getmessage = (" inserted successfully ");
                }
                else if (allquerys.Contains("Delete form"))
                {
                    ret = getmessage = ("delete successfull");
                }
                else if (allquerys.Contains("Update into") && allquerys.Contains("set"))
                {
                    ret = getmessage = ("update successfull");
                }
                else if (allquerys.Contains("Create table"))
                {
                    ret = getmessage = ("create table successful");
                }
            }
            catch (Exception exp)
            {
                ret = getmessage = "failed to execute" + query + "\n resoin :" + exp.Message;
            }
            finally { disconnect(); }
            return ret;
        }
        public string getsingleColumnValueByIndex(string query, out string columndata, int index)
        {
            string ret, val = null;
            try
            {
                cmd_.Connection = conn_;
                cmd_.CommandText = query;
                connect();
                reader_ = cmd_.ExecuteReader();
                while (reader_.Read())
                {
                    val = reader_[index].ToString();
                }
                ret = "Operation Successfull!";
                getmessage = "values successfully got from getSingleValueAsArrayByindex() function";
            }
            catch (Exception exp)
            {
                ret = "Error in datalayer -> getSingleValueAsArrayByIndex() Reason:" + exp.Message;
                getmessage = "Error in datalayer getSingleValueAsArrayByIndex() for reader_ \n" + exp.Message;
            }
            finally
            {
                disconnect();
            }
            columndata = val;
            return ret;
        }
    }
}
