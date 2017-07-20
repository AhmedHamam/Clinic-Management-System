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
    public partial class frm_add_supplier : Form
    {
        public frm_add_supplier()
        {
            InitializeComponent();
        }

        private void btn_Cancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_add_supplier_Load(object sender, EventArgs e)
        {
            if (this.Text == "إضافة مورد جديد")
           txt_supplier_id.Text = Supplier.GetNewCode();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // التحقق من ملأ البيانات المطلوبة
            if (txt_supplier_name.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_supplier_name, "يجب إدخال إسم المورد");
                txt_supplier_name.Focus();
                return;
            }
            if (txt_supplier_address.Text.Trim() == "")
            {
                errorProvider1.SetError(txt_supplier_address, "يجب إدخال عنوان المورد");
                txt_supplier_address.Focus();
                return;
            }
            //==================================================
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            

        }
    }
}
