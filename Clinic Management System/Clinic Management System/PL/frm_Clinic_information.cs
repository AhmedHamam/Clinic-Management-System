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
    public partial class frm_Clinic_information : Form
    {
        public frm_Clinic_information()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                btn_clear.Enabled = true;
                btn_save.Enabled = true;
                btn_edit.Enabled = false;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void frm_Clinic_information_Load(object sender, EventArgs e)
        {
            try
            {
                clinic_information cls = new clinic_information();
                if (!cls.check_clinic_info())
                {
                    DataTable dt = cls.selct_clinic_info();
                    txt_clinic_name.Text = dt.Rows[0][1].ToString();
                    txt_doctorname.Text = dt.Rows[0][2].ToString();
                    txt_clinic_address.Text = dt.Rows[0][3].ToString();
                    txt_clinic_phone.Text = dt.Rows[0][4].ToString();
                    txt_clinic_mobile.Text = dt.Rows[0][5].ToString();
                    txt_clinic_website.Text = dt.Rows[0][6].ToString();
                    txt_clinic_fax.Text = dt.Rows[0][7].ToString();
                    txt_clinic_email.Text = dt.Rows[0][8].ToString();
                    txt_clinic_face.Text = dt.Rows[0][9].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                clinic_information cls = new clinic_information();
                cls.insertdata(txt_clinic_name.Text, txt_doctorname.Text,
                    txt_clinic_address.Text, txt_clinic_phone.Text, 
                    txt_clinic_mobile.Text, txt_clinic_fax.Text, 
                    txt_clinic_email.Text, txt_clinic_website.Text
                    , txt_clinic_face.Text);

                MessageBox.Show("تم الحفظ بنجاح ","رسالة تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text="";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void btn_cancl_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
