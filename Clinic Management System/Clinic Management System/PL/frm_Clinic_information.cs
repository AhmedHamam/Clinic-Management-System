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
            txt_clinic_name.Text = Properties.Settings.Default.clinic_name;
            txt_clinic_address.Text = Properties.Settings.Default.clinic_address;
            txt_clinic_phone.Text = Properties.Settings.Default.clinic_phone;
            txt_clinic_mobile.Text = Properties.Settings.Default.clinic_mobile;
            txt_clinic_website.Text = Properties.Settings.Default.clinic_website;
            txt_clinic_fax.Text = Properties.Settings.Default.clinic_fax;
            txt_clinic_email.Text = Properties.Settings.Default.clinic_email;
            txt_clinic_face.Text = Properties.Settings.Default.clinic_facebook;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.clinic_name = txt_clinic_name.Text;
                Properties.Settings.Default.clinic_address = txt_clinic_address.Text;
                Properties.Settings.Default.clinic_phone = txt_clinic_phone.Text;
                Properties.Settings.Default.clinic_mobile = txt_clinic_mobile.Text;
                Properties.Settings.Default.clinic_fax = txt_clinic_fax.Text;
                Properties.Settings.Default.clinic_website = txt_clinic_website.Text;
                Properties.Settings.Default.clinic_email = txt_clinic_email.Text;
                Properties.Settings.Default.clinic_facebook = txt_clinic_face.Text;
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
