using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frmServerSetting : Form
    {
        public frmServerSetting()
        {
            InitializeComponent();
        }

       

        private void tmrRandomColor_Tick(object sender, EventArgs e)
        {
            
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
            txtServerName.Text = p.Server;
            if (!p.IsWinAuth)
            {
                rdoSql.Checked = true;
                txtUser.Text = p.UserName;
                txtPass.Text = p.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var p = Properties.Settings.Default;
            p.Server = txtServerName.Text;
            if (rdoWin.Checked)
                p.IsWinAuth = true;
            else
            {
                p.IsWinAuth = false;
                p.UserName = txtUser.Text;
                p.Password = txtPass.Text;
            }

            p.Save();
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
