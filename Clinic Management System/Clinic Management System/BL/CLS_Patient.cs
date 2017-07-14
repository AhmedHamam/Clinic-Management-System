using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clinic_Management_System.BL
{
    class CLS_Patient
    {
        //this method To Search Patient
        public DataTable GET_ALL_PATIENT(String ID)
        {
            Connection cnx = new Connection();
            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 20);
            param[0].Value = ID;

            DataTable dt = cnx.ReadData("SP_GET_ALL_PATIENT", param);
            return dt;
        }
        //this method To Insert New  Patient
        public void ADD_PATIENT(string patient_id, string patient_name, string patient_gender, 
            DateTime patient_birth_date,DateTime patient_register_date,string patient_status,string patient_address,string staff_email,
           string patient_contact_no, string patient_contact_no2)
        {
            Connection cnx = new Connection();


            cnx.OpenConnection();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@patient_id", SqlDbType.VarChar,20);
            param[0].Value = patient_id;

            param[1] = new SqlParameter("@patient_name", SqlDbType.VarChar, 50);
            param[1].Value = patient_name;

            param[2] = new SqlParameter("@patient_gender", SqlDbType.VarChar, 10);
            param[2].Value = patient_gender;

            param[3] = new SqlParameter("@patient_birth_date", SqlDbType.DateTime);
            param[3].Value = patient_birth_date;

            param[4] = new SqlParameter("@patient_register_date", SqlDbType.DateTime);
            param[4].Value = patient_register_date;

            param[5] = new SqlParameter("@patient_status", SqlDbType.VarChar,10);
            param[5].Value = patient_status;

            param[6] = new SqlParameter("@patient_address", SqlDbType.VarChar,100);
            param[6].Value = patient_address;

            param[7] = new SqlParameter("@staff_email", SqlDbType.VarChar,20);
            param[7].Value = staff_email;

            param[8] = new SqlParameter("@patient_contact_no", SqlDbType.VarChar,20);
            param[8].Value = patient_contact_no;

            param[9] = new SqlParameter("@patient_contact_no2", SqlDbType.VarChar,20);
            param[9].Value = patient_contact_no2;

            cnx.Exacute_procdure("SP_ADD_PATIENT", param);
            cnx.CloseConnection();
        }

        //this method To Update Patient
        public void UPDATE_PATIENT(string patient_id, string patient_name, string patient_gender,
            DateTime patient_birth_date, DateTime patient_register_date, string patient_status, string patient_address, string staff_email,
           string patient_contact_no, string patient_contact_no2)
        {
            Connection cnx = new Connection();


            cnx.OpenConnection();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@patient_id", SqlDbType.VarChar, 20);
            param[0].Value = patient_id;

            param[1] = new SqlParameter("@patient_name", SqlDbType.VarChar, 50);
            param[1].Value = patient_name;

            param[2] = new SqlParameter("@patient_gender", SqlDbType.VarChar, 10);
            param[2].Value = patient_gender;

            param[3] = new SqlParameter("@patient_birth_date", SqlDbType.DateTime);
            param[3].Value = patient_birth_date;

            param[4] = new SqlParameter("@patient_register_date", SqlDbType.DateTime);
            param[4].Value = patient_register_date;

            param[5] = new SqlParameter("@patient_status", SqlDbType.VarChar, 10);
            param[5].Value = patient_status;

            param[6] = new SqlParameter("@patient_address", SqlDbType.VarChar, 100);
            param[6].Value = patient_address;

            param[7] = new SqlParameter("@staff_email", SqlDbType.VarChar, 20);
            param[7].Value = staff_email;

            param[8] = new SqlParameter("@patient_contact_no", SqlDbType.VarChar, 20);
            param[8].Value = patient_contact_no;

            param[9] = new SqlParameter("@patient_contact_no2", SqlDbType.VarChar, 20);
            param[9].Value = patient_contact_no2;

            cnx.Exacute_procdure("SP_UPDATE_PATIENT", param);
            cnx.CloseConnection();
        }

        //this method To DELETE Patient
        public void Delete_PATIENT(string ID)
        {
            Connection cnx = new Connection();
            cnx.OpenConnection();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 20);
            param[0].Value = ID;
            cnx.Exacute_procdure("SP_DELETE_PATIENT", param);
            cnx.CloseConnection();

        }
    }
}
