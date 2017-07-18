using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_Backup : Form
    {
        public frm_Backup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Your Path..." })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtpath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Connection obcon = new Connection();
            SqlConnection cnx = new SqlConnection(obcon.connectionString);


            string filename = txtpath.Text + "\\Clinic" + DateTime.Now.ToShortDateString().Replace('/', '-')
                + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".bak"; ;
            string strQuery = "Backup Database Clinic to Disk ='" + filename + ".bak'";
            SqlCommand cmd = new SqlCommand(strQuery, cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("تم أنشاء النسخة الاحتياطية بنجاح", "أنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
