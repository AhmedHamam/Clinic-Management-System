using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Clinic_Management_System
{
    class CLS_Login
    {
        public DataTable StaffLogin(string UserName , string Password)
        {
            Connection Conn = new Connection();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@StaffName", SqlDbType.VarChar , 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@StaffPassword", SqlDbType.VarChar, 10);
            param[1].Value = Password;
            return Conn.ReadData("StaffLogin", param);
        }
    }
}
