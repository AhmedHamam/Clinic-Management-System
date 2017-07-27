using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            //------------------ Mohamed Moafa Code For Execute Style ----------------
            skinEngine1.SkinFile = "Skins\\" + Properties.Settings.Default.Style;
            //------------------------------------------------------------------------
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                cb_showpassword.Image = Properties.Resources.Hide_32x32;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                cb_showpassword.Image = Properties.Resources.Show_32x32;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
	        {
                Application.Exit();	 
	        }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Factory Setting" && txt_password.Text == "Factory Setting")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                CLS_Login Connection = new CLS_Login();
                DataTable DT = Connection.StaffLogin(txt_username.Text, txt_password.Text);
                if (DT.Rows.Count > 0)
                {
                    Program.LogInRaw = int.Parse(DT.Rows[0][2].ToString());
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("wrong username or password");
                }
            }
        }
    }
}
