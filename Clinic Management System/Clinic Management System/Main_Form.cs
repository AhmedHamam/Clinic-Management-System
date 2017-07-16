using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Log_in frm = new Log_in();
            frm.ShowDialog();
        }

        private void btnManageStaff_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.ShowDialog();
        }


        private void btn_supplier_Click(object sender, EventArgs e)
        {
            frm_Supplier frm = new frm_Supplier();
            frm.ShowDialog();
        }

        private void btnPatinet_Click(object sender, EventArgs e)
        {
            frm_Patient frmptn = new frm_Patient();
            frmptn.ShowDialog();

        }

        private void btnServerSeting_Click(object sender, EventArgs e)
        {
            frmServerSetting frmS = new frmServerSetting();
            frmS.ShowDialog();
        }
    }
}
