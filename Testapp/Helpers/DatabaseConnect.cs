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
        public string PendingQuery = "";
        public List<string> PendingQueryList = new List<string>();
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
            return getAll("");
        }
        public List<T> getAll(string filter)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name+" "+ filter +" order by ID";
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            if (dt.Rows.Count > 0)
                return Mapper.ConvertDataTable<T>(dt);
            else
                return new List<T>();
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

        public T getOneBy(string fieldName,object val)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select * from " + typeof(T).Name + " where " + fieldName +" = '"+val+"'";
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

        public void Save(Object obj)
        {
            if ((obj as Model).isSaveable)
            {
                OleDbCommand cmd = con.CreateCommand();
                con.Open();
                string columns = string.Join(",", DatabaseHelper.GetProperties<T>());
                string values = string.Join(",", DatabaseHelper.GetValues<T>(obj));
                string query = "";
                if (!(obj as Model).isNew)
                {
                    int id = DatabaseHelper.getID<T>(obj);
                    query = "UPDATE " + typeof(T).Name + " SET " + DatabaseHelper.GetUpdateStatement<T>(obj) + " WHERE ID = " + id;
                }
                else
                {
                    query = @"INSERT INTO " + typeof(T).Name + "(" + columns + ")VALUES (" + values + ");";
                }
                cmd.CommandText = query;
                cmd.Connection = con;
                int result = cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                throw new Exception("Object marked as non-savable");
            }
        }

        public void SaveAsTransaction(Object obj)
        {
            if ((obj as Model).isSaveable)
            {
                //OleDbCommand cmd = con.CreateCommand();
                //con.Open();
                string columns = string.Join(",", DatabaseHelper.GetProperties<T>());
                string values = string.Join(",", DatabaseHelper.GetValues<T>(obj));
                string query = "";
                if (!(obj as Model).isNew)
                {
                    int id = DatabaseHelper.getID<T>(obj);
                    query = "UPDATE " + typeof(T).Name + " SET " + DatabaseHelper.GetUpdateStatement<T>(obj) + " WHERE ID = " + id +";";
                }
                else
                {
                    query = @"INSERT INTO " + typeof(T).Name + "(" + columns + ")VALUES (" + values + ");";
                }
                this.PendingQuery = this.PendingQuery + query;
                this.PendingQueryList.Add(query);
                //cmd.CommandText = query;
                //cmd.Connection = con;
                //int result = cmd.ExecuteNonQuery();
                //con.Close();
            }
            else
            {
                throw new Exception("Object marked as non-savable");
            }
        }


        public void Delete(Object obj)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            int id = DatabaseHelper.getID<T>(obj);
            string query = "DELETE FROM " + typeof(T).Name + " WHERE ID = " +id;
            
            cmd.CommandText = query;
            cmd.Connection = con;
            int result = cmd.ExecuteNonQuery();
            con.Close();
        }

        public List<T> getListCustomQuery(string query)
        {
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = query;
            cmd.Connection = con;
            OleDbDataReader d = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(d);
            con.Close();
            if(dt.Rows.Count>0)
                return Mapper.ConvertDataTable<T>(dt);
            else
                return new List<T>();
        }

        public void CommitTransaction()
        {
            if (PendingQueryList.Count>0)
            {
                con.Open();
                    OleDbTransaction transaction = con.BeginTransaction();
                    foreach (string statement in PendingQueryList)
                    {
                        using (OleDbCommand cmd = new OleDbCommand(statement, con, transaction))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    transaction.Commit();

                con.Close();
            }
            else
            {
                throw new Exception("No Pending Transaction.");
            }
        }

        
    }
}
