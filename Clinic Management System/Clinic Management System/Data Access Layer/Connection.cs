using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Clinic_Management_System
{
    class Connection
    {
        public string connectionString;
        private SqlConnection connection;
        public Connection()
        {
            var p = Properties.Settings.Default;
            if (p.IsWinAuth)
                connectionString = @"SERVER=" + p.Server + ";DATABASE=Clinic;Integrated Security=true";
            else
                connectionString = @"SERVER=" + p.Server + ";DATABASE=Clinic;Integrated Security=false;User Id=" + p.UserName + ";Password=" + p.Password + "";
            connection = new SqlConnection(connectionString);
        }
        public Connection(string ServerName , string UserName , string Password , bool WinAuth)
        {
            if (WinAuth)
                connectionString = @"SERVER=" + ServerName + ";DATABASE=Clinic;Integrated Security=true";
            else
                connectionString = @"SERVER=" + ServerName + ";DATABASE=Clinic;Integrated Security=false;User Id=" + UserName + ";Password=" + Password + "";
            connection = new SqlConnection(connectionString);
        }
        //open connection to database
        public bool OpenConnection()
        {

            //check connection is close or not 
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
            return true;
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
        public DataTable ReadData(string stored_procdure)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
               
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
        public bool Exacute_procdure(string stored_procdure, SqlParameter[] parameter)
        {
            SqlCommand cmd = new SqlCommand();
            
                OpenConnection();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = stored_procdure;
                cmd.Connection = connection;
                if (parameter != null)
                {
                    cmd.Parameters.AddRange(parameter);
                }
               int r = cmd.ExecuteNonQuery();
                CloseConnection();
                if (r > 0)
                    return true;
                else
                    return false;
            
            
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
                    MessageBox.Show(e.Message);
                }
                //close connection
                finally
                {
                    this.CloseConnection();
                }

            }

            return id;
        }
        // convert image to byte - write image in database
        public static byte[] ConvertImageToBytes(System.Drawing.Image img)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        // convert image to image - read image from database
        public static System.Drawing.Image ConvertBytesToImage(byte[] byt)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byt);
            return System.Drawing.Image.FromStream(ms);

        }

        public string getidWithRemoveChar(string tabel,string column,string chars)
        {
            string id = "";

            
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select max("+column+") from " + tabel + " ;";
                cmd.Connection = connection;
                try
                {
                    id = (string)cmd.ExecuteScalar();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                //close connection
                finally
                {
                    this.CloseConnection();
                }
                return id.Remove(id.IndexOf(chars), chars.Length);
        }
    }
}

