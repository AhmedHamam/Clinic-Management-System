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
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (Supplier.add_supplier(int.Parse(frm.txt_supplier_id.Text), frm.txt_supplier_name.Text, frm.txt_supplier_address.Text, frm.txt_supplier_phone.Text) == true)
                    dqv_suppliers.DataSource = Supplier.SPSelectSupplier("");
                else
                    MessageBox.Show("فشل في إضافة المورد");

            }
        }

        private void btn_edit_supp_Click(object sender, EventArgs e)
        {
            frm_add_supplier frm = new frm_add_supplier();
            frm.Text = "تعديل بيانات مورد";
            if (dqv_suppliers.Rows.Count > 0)
            {
                frm.txt_supplier_id.Text = dqv_suppliers.CurrentRow.Cells[0].Value.ToString();
                frm.txt_supplier_name.Text = dqv_suppliers.CurrentRow.Cells[1].Value.ToString();
                frm.txt_supplier_address.Text = dqv_suppliers.CurrentRow.Cells[2].Value.ToString();
                frm.txt_supplier_phone.Text = dqv_suppliers.CurrentRow.Cells[3].Value.ToString();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    if (Supplier.update_supplier(int.Parse(frm.txt_supplier_id.Text), frm.txt_supplier_name.Text, frm.txt_supplier_address.Text, frm.txt_supplier_phone.Text) == true)
                        dqv_suppliers.DataSource = Supplier.SPSelectSupplier("");
                    else
                        MessageBox.Show("فشل في تحديث المورد");
                }
            }
            
        }

        private void frm_Supplier_Load(object sender, EventArgs e)
        {
            dqv_suppliers.DataSource = Supplier.SPSelectSupplier("");
        }

        private void txt_supp_search_TextChanged(object sender, EventArgs e)
        {
          //  btn_search.PerformClick();
        }

       

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dqv_suppliers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف المورد المحدد؟","تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Supplier.delete_supplier(int.Parse(dqv_suppliers.CurrentRow.Cells[0].Value.ToString())) == true)
                    {
                        dqv_suppliers.DataSource = Supplier.SPSelectSupplier("");
                        MessageBox.Show("تم حذف المورد المحدد بنجاح");
                    }
                    else
                        MessageBox.Show("فشل في حذف المورد المحدد");
                }
            }
        }

        private void txt_supp_search_Enter(object sender, EventArgs e)
        {
            if (txt_supp_search.Tag == (object)"0")
                txt_supp_search.Clear();

        }

        private void txt_supp_search_Leave(object sender, EventArgs e)
        {
            if (txt_supp_search.Text.Trim() == "")
            {
                txt_supp_search.Tag = "0";
                txt_supp_search.Text = "Search";

            }
            else
                txt_supp_search.Tag = "1";
        }

        private void txt_supp_search_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                dqv_suppliers.DataSource = Supplier.SPSelectSupplier(txt_supp_search.Text);
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FunMenu();
        }

        private void FunMenu()
        {
            if (btnMenu.Tag == (object)"0")
            {
                pnlMenu.Width = 180;
                btnMenu.Left = 150;
                txt_supp_search.Visible = true;
                btnMenu.Tag = "1";
            }
            else
            {
                pnlMenu.Width = 30;
                btnMenu.Left = 6;
                txt_supp_search.Visible = false;
                btnMenu.Tag = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
