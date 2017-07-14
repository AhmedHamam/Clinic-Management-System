using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    class Supplier
    {
       static Connection DB = new Connection();
        // Get Last record
        public static string GetNewCode()
        {
        int id = int.Parse(DB.getid("Supplier"))+1;
        return id.ToString();
        }
        // Add
        public static bool add_supplier(int @sup_id, string @sup_name, string @sup_address, string @sup_contat)
        {
            try{
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@sup_id",@sup_id),
             new SqlParameter("@sup_name",@sup_name),
              new SqlParameter("@sup_address",@sup_address),
               new SqlParameter("@sup_contat",@sup_contat),
            };
            DB.Exacute_procdure("add_supplier", param);
            return true;
            }
            catch{return false;}
        }

        // Display
        public static DataTable SPSelectSupplier(string param1)
        { 
            SqlParameter[] param = new SqlParameter[1]
            {
            new SqlParameter("@param1",param1)
            };
          return DB.ReadData("SPSelectSupplier",param);
        }

        // Update Data
        public static bool update_supplier(int @sup_id, string @sup_name, string @sup_address, string @sup_contat)
        {
            try{
            SqlParameter[] param = new SqlParameter[]
            {
            new SqlParameter("@sup_id",@sup_id),
             new SqlParameter("@sup_name",@sup_name),
              new SqlParameter("@sup_address",@sup_address),
               new SqlParameter("@sup_contat",@sup_contat),
            };
            DB.Exacute_procdure("update_supplier", param);
            return true;
            }
            catch{return false;}
        
        }
    // Delete 
        public static bool delete_supplier(int @sup_id)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[1]
            {
            new SqlParameter("@sup_id",sup_id)
            };
                DB.Exacute_procdure("delete_supplier", param);
                return true;
            }
            catch { return false; }
        }
    
    }
}
