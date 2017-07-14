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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnNewStaff_CheckedChanged(object sender, EventArgs e)
        {
            pnlUnderLineTab.Left = btnNewStaff.Left;
            pnlUnderLineTab.Width = btnNewStaff.Width;
            pnlTabContent.Controls.Clear();
            ucNewStaff ucns = new ucNewStaff();
            pnlTabContent.Controls.Add(ucns);

        }

        private void btnManageStaff_CheckedChanged(object sender, EventArgs e)
        {
            pnlUnderLineTab.Left = btnManageStaff.Left;
            pnlUnderLineTab.Width = btnManageStaff.Width;
            pnlTabContent.Controls.Clear();
            ucManageStaff ucms = new ucManageStaff();
            pnlTabContent.Controls.Add(ucms);
        }
        Random r = new Random();
        private void tmrRandomColorTab_Tick(object sender, EventArgs e)
        {
            btnNewStaff.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            btnManageStaff.ForeColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }
    }
}
