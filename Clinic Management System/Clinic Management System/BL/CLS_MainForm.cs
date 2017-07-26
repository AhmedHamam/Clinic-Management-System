using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Clinic_Management_System
{
    class CLS_MainForm
    {
        public DataTable CurrentUser(int id)
        {
            Connection Conn = new Connection();
            SqlParameter[] param = {new SqlParameter("@StaffID", id) , new SqlParameter("@StaffName", "") };
            return Conn.ReadData("CheckExists" , param);
        }
    }
}
