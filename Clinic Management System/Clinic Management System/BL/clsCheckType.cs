using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Clinic_Management_System
{
    
    class clsCheckType
    {
        Connection DB = new Connection();

        
        
        
        public int NewCheckType()
        {
            int num =int.Parse(DB.getidWithRemoveChar("Chekup_Type", "Code", "CT"));
            num++;
            return num;
        }

        public void Insert_CheckType(string code,string typeName,string Price,string Note)
        {
            SqlParameter[] param = 
            {
            new SqlParameter("@code",code),
            new SqlParameter("@typeName",typeName),
            new SqlParameter("@Price",Price),
            new SqlParameter("@Note",Note)  
            };
            DB.Exacute_procdure("SP_Insert_CheckType", param);
        }

        public DataTable Select_CheckType()
        {
            return DB.ReadData("SP_Select_CheckType", null);
        }

        public bool Update_CheckType(string code, string typeName, string Price, string Note,out string resultMessage)
        {
            try
            {
                SqlParameter[] param = 
            {
            new SqlParameter("@code",code),
            new SqlParameter("@typeName",typeName),
            new SqlParameter("@Price",Price),
            new SqlParameter("@Note",Note)  
            };
               if(DB.Exacute_procdure("SP_Update_CheckType", param))
                resultMessage = "تم تحديث السجل بنجاح";
                else
                   resultMessage = "فشل في تحديث السجل ";
               return true;
            }
            catch(Exception ex)
            {
                resultMessage = ex.Message;
                return false;
            }
        }

        public bool Delete_CheckType(string code)
        {
            try
            {
                SqlParameter[] param = { new SqlParameter("@code", code) };
                if (DB.Exacute_procdure("SP_Delete_CheckType", param))
                    return true;
                else
                    return false;
            } 
            catch
            { return false; }
        }
    
    }
}
