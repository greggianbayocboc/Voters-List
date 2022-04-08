using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Testapp.Helpers;
using Npgsql;

namespace Testapp
{
    public class DatabaseConnectPostgresql<T>
    {
     
            NpgsqlConnection conn = new NpgsqlConnection(String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                    gregg.Properties.Settings.Default.server, 
                    gregg.Properties.Settings.Default.port, 
                    gregg.Properties.Settings.Default.username,
                    gregg.Properties.Settings.Default.password, "voters"));
      

        public string PendingQuery = "";
        public List<string> PendingQueryList = new List<string>();
        public void ExecuteNonQuery(string query)
        {
            //checkDatabaseConfiguration();
            conn.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            conn.Close();

        }

        public DataTable ExecuteTabularQuery(string query)
        {
            //checkDatabaseConfiguration();

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
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
            //checkDatabaseConfiguration();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "Select * from " + typeof(T).Name + " " + filter + " order by ID";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
           
            if (dt.Rows.Count > 0)
                return Mapper.ConvertDataTable<T>(dt);
            else
                return new List<T>();
        }

        public T getOne(int id)
        {
            //checkDatabaseConfiguration();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "Select * from " + typeof(T).Name + " where ID = " + id;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }

        public T getOneBy(string fieldName,object val)
        {
            //checkDatabaseConfiguration();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "Select * from " + typeof(T).Name + " where " + fieldName + " = '" + val + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }


        public bool doExist(string fieldName, object val)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "Select * from " + typeof(T).Name + " where " + fieldName + " = '" + val + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return dt.Rows.Count>0;
        }

        public T getFirst()
        {
           // checkDatabaseConfiguration();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            string query = "Select * from " + typeof(T).Name;
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();
            return Mapper.GetItem<T>(dt.Rows[0]);
        }

        public void Save(Object obj)
        {
            //checkDatabaseConfiguration();
            if ((obj as Model).isSaveable)
            {
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
               
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                //NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
                conn.Close();
            }
            else
            {
                throw new Exception("Object marked as non-savable");
            }
        }

        public void SaveAsTransaction(Object obj)
        {
            //checkDatabaseConfiguration();
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
            //checkDatabaseConfiguration();
            int id = DatabaseHelper.getID<T>(obj);
            string query = "DELETE FROM " + typeof(T).Name + " WHERE ID = " +id;
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            conn.Close();
        }

        public List<T> getListCustomQuery(string query)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            conn.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            conn.Close();

            if (dt.Rows.Count > 0)
                return Mapper.ConvertDataTable<T>(dt);
            else
                return new List<T>();
        }

        public void CommitTransaction()
        {
            //checkDatabaseConfiguration();
            if (PendingQueryList.Count>0)
            {
                conn.Open();

                //NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, conn);

                    NpgsqlTransaction transaction = conn.BeginTransaction();
                        NpgsqlCommand cmd = new NpgsqlCommand(PendingQuery, conn);
                        cmd.ExecuteNonQuery();
                    transaction.Commit();
                
                conn.Close();
                PendingQueryList = new List<string>();
                PendingQuery = "";
            }
            else
            {
                //throw new Exception("No Pending Transaction.");
            }
        }
        public bool checkDatabaseConfiguration()
        {
            if (conn.ConnectionString == string.Empty)
            {
                gregg.Forms.DatabaseConfigurationForm configForm = new gregg.Forms.DatabaseConfigurationForm();
                configForm.Text = "Database Configuration not found!";
                configForm.ShowDialog();
                return true;
            }
            else
                return true;
        }
        
    }
}
