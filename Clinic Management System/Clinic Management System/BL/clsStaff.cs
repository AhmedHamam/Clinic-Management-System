using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
namespace Clinic_Management_System
{
    public class clsStaff
    {
        Connection db = new Connection();
        public void SP_Insert_Staff(int id , string name , int contactno1 , int contactno2 , string adress , string email , DateTime birthdate , DateTime employeedate , string positon , string status , string gender , byte[] image)
        {
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@StaffID", "int");
            param[0].Value = id;

            param[1] = new SqlParameter("@StaffName", SqlDbType.VarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@StaffBirthdate", SqlDbType.Date);
            param[2].Value = birthdate;

            param[3] = new SqlParameter("@StaffAdress", SqlDbType.VarChar, 100);
            param[3].Value = adress;

            param[4] = new SqlParameter("@StaffContactNO", "int");
            param[4].Value = contactno1;

            param[5] = new SqlParameter("@StaffContactNO2", "int");
            param[5].Value = contactno2;

            param[6] = new SqlParameter("@StaffGender", SqlDbType.VarChar, 10);
            param[6].Value = gender;

            param[7] = new SqlParameter("@StaffPostion", SqlDbType.VarChar, 10);
            param[7].Value = positon;

            param[8] = new SqlParameter("@StaffStatus", SqlDbType.VarChar, 10);
            param[8].Value = status;

            param[9] = new SqlParameter("@StaffEmail", SqlDbType.VarChar, 20);
            param[9].Value = email;

            param[10] = new SqlParameter("@StaffDateofEmployee", SqlDbType.Date);
            param[10].Value = employeedate;

            param[11] = new SqlParameter("@StaffPicture", "image");
            param[11].Value = image;

            db.OpenConnection();
            db.Exacute_procdure("AddStaff", param);
            db.CloseConnection();
        }

        public void SP_Edit_Staff(int id, int contactno1, int contactno2, string adress, string email, DateTime birthdate, DateTime employeedate, string positon, string status, string gender, byte[] image)
        {
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@StaffID", "int");
            param[0].Value = id;

            param[1] = new SqlParameter("@StaffBirthdate", SqlDbType.Date);
            param[1].Value = birthdate;

            param[2] = new SqlParameter("@StaffAdress", SqlDbType.VarChar, 100);
            param[2].Value = adress;

            param[3] = new SqlParameter("@StaffContactNO", "int");
            param[3].Value = contactno1;

            param[4] = new SqlParameter("@StaffContactNO2", "int");
            param[4].Value = contactno2;

            param[5] = new SqlParameter("@StaffGender", SqlDbType.VarChar, 10);
            param[5].Value = gender;

            param[6] = new SqlParameter("@StaffPostion", SqlDbType.VarChar, 10);
            param[6].Value = positon;

            param[7] = new SqlParameter("@StaffStatus", SqlDbType.VarChar, 10);
            param[7].Value = status;

            param[8] = new SqlParameter("@StaffEmail", SqlDbType.VarChar, 20);
            param[8].Value = email;

            param[9] = new SqlParameter("@StaffDateofEmployee", SqlDbType.Date);
            param[9].Value = employeedate;

            param[10] = new SqlParameter("@StaffPicture", "image");
            param[10].Value = image;

            db.OpenConnection();
            db.Exacute_procdure("UpdateStaff", param);
            db.CloseConnection();
        }

        public void SP_Delete_Staff(int id)
        {
            SqlParameter[] param = { new SqlParameter("@StaffID" , id.ToString()) };

            db.OpenConnection();
            db.Exacute_procdure("DeletStaff", param);
            db.CloseConnection();
        }

        public DataTable SP_Search_Staff(string StaffName)
        {
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@StaffName", SqlDbType.VarChar, 100);
            param[0].Value = StaffName;

            return db.ReadData("SearchStaff", param);
        }

        public DataTable SP_Get_Staff_Table()
        {
            return db.ReadData("GetStaffTable", null);
        }

        public Image SP_Get_Image_Staff(int id)
        {
            DataTable Result;
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@StaffID", SqlDbType.VarChar, 20);
            param[0].Value = id;
            return Connection.ConvertBytesToImage((byte[])db.ReadData("GetPicture", param).Rows[0][0]);
        }

        public DataTable CheckExists(int id , string name)
        {
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@StaffID", SqlDbType.VarChar, 20);
            param[0].Value = id;

            param[1] = new SqlParameter("@StaffName", SqlDbType.VarChar, 50);
            param[1].Value = name;

            return db.ReadData("CheckExists", param);
        }
    }
}
