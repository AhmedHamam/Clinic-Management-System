using System.Data;
using System.Data.SqlClient;

namespace Clinic_Management_System
{
    class clinic_information
    {
        Connection con=new Connection();
        public bool check_clinic_info()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter=new SqlParameter[0];
            dt = con.ReadData("select_clinic_info", parameter);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        public DataTable selct_clinic_info()
        {
            DataTable dt = new DataTable();
            SqlParameter[] parameter = new SqlParameter[0];
            dt = con.ReadData("select_clinic_info", parameter);
            return dt;
        }
        public void insertdata(string name,string doctor,string address,string telephone,
            string mobile,string fax,string email,string website,string fb_page)
        {
            if (check_clinic_info())
            {
                SqlParameter[] param = new SqlParameter[9];
                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[0].Value = name;
                param[1] = new SqlParameter("@doctor_name", SqlDbType.VarChar, 50);
                param[1].Value = doctor;
                param[2] = new SqlParameter("@address", SqlDbType.VarChar, 50);
                param[2].Value = address;
                param[3] = new SqlParameter("@telephone", SqlDbType.VarChar, 14);
                param[3].Value = telephone;
                param[4] = new SqlParameter("@moblie", SqlDbType.VarChar, 14);
                param[4].Value = mobile;
                param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 50);
                param[5].Value = fax;
                param[6] = new SqlParameter("@email", SqlDbType.VarChar, 50);
                param[6].Value = email;
                param[7] = new SqlParameter("@website", SqlDbType.VarChar, 50);
                param[7].Value = website;
                param[8] = new SqlParameter("@fb_page", SqlDbType.VarChar, 100);
                param[8].Value = fb_page;
                con.Exacute_procdure("add_clinic_info",param);

            } 
            else
            {
                SqlParameter[] param = new SqlParameter[9];
                param[0] = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                param[0].Value = name;
                param[1] = new SqlParameter("@doctor_name", SqlDbType.VarChar, 50);
                param[1].Value = doctor;
                param[2] = new SqlParameter("@address", SqlDbType.VarChar, 50);
                param[2].Value = address;
                param[3] = new SqlParameter("@telephone", SqlDbType.VarChar, 14);
                param[3].Value = telephone;
                param[4] = new SqlParameter("@moblie", SqlDbType.VarChar, 14);
                param[4].Value = mobile;
                param[5] = new SqlParameter("@fax", SqlDbType.VarChar, 50);
                param[5].Value = fax;
                param[6] = new SqlParameter("@email", SqlDbType.VarChar, 50);
                param[6].Value = email;
                param[7] = new SqlParameter("@website", SqlDbType.VarChar, 50);
                param[7].Value = website;
                param[8] = new SqlParameter("@fb_page", SqlDbType.VarChar, 100);
                param[8].Value = fb_page;
                con.Exacute_procdure("update_clinic_info", param);
            }
        }
    }
}
