using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinic_Management_System
{
    public partial class Frm_add_user : Form
    {
        public Frm_add_user()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_password.Text == txt_repeat_password.Text)
                {

                }
                else
                {
                    MessageBox.Show("كلمتا السر غير متطابقتان ","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Frm_add_user_Load(object sender, EventArgs e)
        {
            if (this.Text != "تعديل ")
            {
                Connection con = new Connection();
                DataTable dt = new DataTable();
                SqlParameter[] parm = new SqlParameter[0];
                if (dt.Columns.Count < 1)
                {
                    MessageBox.Show("تم تسجيل جميع الموظفين ", "تم تسجيل جميع الموظفين", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                else
                {
                    dt = con.ReadData("selct_staff_without_users", parm);
                    cb_staff.DataSource = dt;
                    cb_staff.DisplayMember = "staff_name";
                    cb_staff.ValueMember = "staff_id";

                }
            }
            else 
            {
            }
        }
    }
}
