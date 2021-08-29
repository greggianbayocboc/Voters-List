using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Testapp.Helpers;

namespace Testapp
{
    public class DatabaseConnect<T>
    {
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=testapp.accdb");

        public void ExecuteNonQuery(string query)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public DataTable ExecuteTabularQuery(string query)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            return dt;
        }

        public string myClassName() {
            return this.GetType().ToString();
        }

        public List<T> getAll()
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name;
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            return Mapper.ConvertDataTable<T>(dt);
        }

        public T getOne(int id)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name + " where ID = " + id;
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }

        public T getFirst()
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name;
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }

        public T Save()
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name;

            string query = @"INSERT INTO tblProducts (ProductName,
                            CategoryDescription, UnitPrice)
                            VALUES ('Support Renewal', 'Multi-User', 99);";
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }
        
    }
}
