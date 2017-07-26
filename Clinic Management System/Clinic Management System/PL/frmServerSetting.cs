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
    public partial class frmServerSetting : Form
    {
        public frmServerSetting()
        {
            InitializeComponent();
        }

        private void rdoSql_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSql.Checked)
            {
                pnlLogin.Enabled = true;
                txtUser.Focus();
            }
            else
            {
                pnlLogin.Enabled = false;
                btnSave.Focus();
            }
        }

        private void frmServerSetting_Load(object sender, EventArgs e)
        {
            var p = Properties.Settings.Default;
            if (p.Server == "")
            {
                txtServerName.Text = ".";
            }
            else
            {
                txtServerName.Text = p.Server;
            }
            if (!p.IsWinAuth)
            {
                rdoSql.Checked = true;
                txtUser.Text = p.UserName;
                txtPass.Text = p.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CLS_ServerSettings Serverconn = new CLS_ServerSettings();
            if (Serverconn.TestConnection(txtServerName.Text, txtUser.Text, txtPass.Text, rdoWin.Checked) == true)
            {
                if (RemeberSettings.Checked == true)
                {
                    var p = Properties.Settings.Default;
                    p.Server = txtServerName.Text;
                    p.IsWinAuth = rdoWin.Checked;
                    p.UserName = txtUser.Text;
                    p.Password = txtPass.Text;
                    p.Save();
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Couldn't connect to server \n possiple reasons : \n 1.wrong input , check your input! \n 2. no internet connection , check your internet connection!", "Couldn't connect to server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
