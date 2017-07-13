using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Clinic_Management_System
{
    class Connection
    {
        public string connectionString = "SERVER=localhost;DATABASE=Clinic;Uid=root;pwd=root";
        private SqlConnection connection;
        public Connection()
        {
            connection = new SqlConnection(connectionString);
        }
        //open connection to database
        public void OpenConnection()
        {

            //check connection is close or not 
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        //Close connection
        public void CloseConnection()
        {
            //check connection is open or not 
            if (connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
        //method to read data from database
        public DataTable ReadData(string stored_procdure, SqlParameter[] parameter)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                if (parameter != null)
                {
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.Add(parameter[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        //method to insert or update or delete data from database 
        public void Exacute_procdure(string stored_procdure, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                if (parameter != null)
                {
                    cmd.Parameters.AddRange(parameter);
                }
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public string getid(string tabel)
        {
            string id = "";

            if (true)
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select count('*') from " + tabel + " ;";
                cmd.Connection = connection;
                try
                {
                    id = cmd.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                //close connection
                finally
                {
                    this.CloseConnection();
                }

            }

            return id;
        }
    }
}

