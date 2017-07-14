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
    public partial class frm_Supplier : Form
    {
        public frm_Supplier()
        {
            InitializeComponent();
        }

        private void btn_add_supplier_Click(object sender, EventArgs e)
        {
            frm_add_supplier frm = new frm_add_supplier();
            frm.Show();
        }

        private void btn_edit_supp_Click(object sender, EventArgs e)
        {
            frm_add_supplier frm = new frm_add_supplier();
            frm.Text = "تعديل بيانات مورد";
            frm.Show();
        }
    }
}
