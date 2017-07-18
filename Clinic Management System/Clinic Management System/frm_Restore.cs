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
    public partial class frm_Restore : Form
    {
        public frm_Restore()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog op = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "Backup (*.bak)|*.bak" })
                {
                    if (op.ShowDialog() == DialogResult.OK)
                    {
                        txtpath.Text = op.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Connection obcon = new Connection();
                SqlConnection cnx = new SqlConnection(obcon.connectionString);

                string filename = txtpath.Text + "\\Clinic " + DateTime.Now.ToShortDateString().Replace('/', '-')
                    + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".bak";
                //
                SqlCommand cmd = new SqlCommand("ALTER Database Clinic SET OFFLINE WITH ROLLBACK IMMEDIATE; Restore database Clinic from Disk='"
                    + txtpath.Text + "'  with replace, recovery", cnx);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                MessageBox.Show("تم استعادة النسخة لاحتياطية بنجاح", "أستعادة نسخة أحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }
    }
}
