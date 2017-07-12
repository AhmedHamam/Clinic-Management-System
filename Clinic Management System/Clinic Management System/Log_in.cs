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

            //------------------ Mohamed Moafa Code For Fill Combobox with names of styles  ----------------
            try
            {
                if (Directory.Exists("Skins"))
                    foreach (string file in Directory.GetFiles("Skins"))
                       cmbStyle.Items.Add(Path.GetFileName(file));
                cmbStyle.Text = Properties.Settings.Default.Style;
            }
            catch { }
            //-----------------------------------------------------------------------------------------------
        }

        private void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpassword.Checked)
            {
                txt_password.UseSystemPasswordChar = false;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Hide_32x32;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
                cb_showpassword.Image = global::Clinic_Management_System.Properties.Resources.Show_32x32;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("هل تريد الخروج من البرنامج ", "تنبيه ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr==DialogResult.OK)
	        {
                Application.Exit();	 
	        }
            else
            {
            }
        }

        private void cmbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            //------------------ Mohamed Moafa Code For Change styles  ----------------
            try
            {
                Properties.Settings.Default.Style = cmbStyle.Text;
                Properties.Settings.Default.Save();
                skinEngine1.SkinFile = "Skins\\" + cmbStyle.Text;
            }
            catch { }
            //-----------------------------------------------------------------------------------------------
        
        }
    }
}
