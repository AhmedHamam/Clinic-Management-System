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
    public partial class frmChekup_Type : Form
    {
        clsCheckType ct = new clsCheckType();
        public frmChekup_Type()
        {
            InitializeComponent();
        }

       

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtName.Clear();
            nudPrice.ResetText();
            txtNote.Clear();
           txtCode.Text = "CT"+ct.NewCheckType();
           txtName.Focus();
        }

        private void frmChekup_Type_Load(object sender, EventArgs e)
        {
            FillDGV();
            btnNew_Click(null, null);
        }

        private void FillDGV()
        {
            dgvCheckType.DataSource = ct.Select_CheckType();
            
        }

        private void dgvCheckType_SelectionChanged(object sender, EventArgs e)
        {
            var currentRow = dgvCheckType.CurrentRow;
            txtCode.Text = currentRow.Cells["Code"].Value.ToString();
            txtName.Text = currentRow.Cells["TypeName"].Value.ToString();
            nudPrice.Value = (decimal)currentRow.Cells["Price"].Value;
            txtNote.Text = currentRow.Cells["Note"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtName.Text.Trim()=="")
                {
                    txtName.Focus();
                    return;
                }

                if (nudPrice.Text.Trim() == "")
                {
                    nudPrice.Focus();
                    return;
                }

                

                ct.Insert_CheckType(txtCode.Text, txtName.Text, nudPrice.Value.ToString(), txtNote.Text);
                FillDGV();
                // show message if good
                
            }
            catch
            { 
            // show message also
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                txtName.Focus();
                return;
            }

            if (nudPrice.Text.Trim() == "")
            {
                nudPrice.Focus();
                return;
            }


            string result;
           ct.Update_CheckType(txtCode.Text, txtName.Text, nudPrice.Value.ToString(), txtNote.Text, out result);
           MessageBox.Show(result);
           FillDGV();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ct.Delete_CheckType(txtCode.Text))
            {
                FillDGV();
                MessageBox.Show("تم عملية الحذف بنجاح");
            }
            else
                MessageBox.Show("فشلت العملية");

            
        }
    }
}
