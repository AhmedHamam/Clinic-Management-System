﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            StaffSearchForm frm = new StaffSearchForm();
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

        private void btn_createBackup_Click(object sender, EventArgs e)
        {
            frm_Backup bkp = new frm_Backup();
            bkp.ShowDialog();
        }

        private void btn_clinic_info_Click(object sender, EventArgs e)
        {
            frm_Clinic_information frm = new frm_Clinic_information();
            frm.ShowDialog();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            frm_Restore rst = new frm_Restore();
            rst.ShowDialog();
        }

        // فتح شاشة تسجيل الدخول
        private void msLogin_Click(object sender, EventArgs e)
        {
            Log_in frm = new Log_in();
            frm.ShowDialog();
        }
        // تحميل استايل النظام
        ToolStripMenuItem temp;
        private void Main_Form_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
            skinEngine1.SkinFile = "Skins\\"+Properties.Settings.Default.Style;
            try
            {
                if (Directory.Exists("Skins"))
                    foreach (string file in Directory.GetFiles("Skins"))
                    {
                        var item = msStyles.DropDownItems.Add(Path.GetFileName(file));
                        item.Click += item_Click;
                        if (Properties.Settings.Default.Style == item.Text)
                        {
                            (item as ToolStripMenuItem).Checked = true;
                            temp = item as ToolStripMenuItem;
                        }
                       
                        
                    }

            }
            catch { }
        }
        // حدث الاستايلات
        void item_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            skinEngine1.SkinFile = "Skins\\" + item.Text;
            
                temp.Checked = false;
                item.Checked = true;
                temp = item;
            
        }

        private void msStyles_Click(object sender, EventArgs e)
        {

           
          
            
        }

        // حفظ الاستايل المختار في الاعدادات
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Style = Path.GetFileName(skinEngine1.SkinFile);
            Properties.Settings.Default.Save();
        }

        // عرض شاشة اعدادات السيرفر
        private void msServerSetting_Click(object sender, EventArgs e)
        {
            frmServerSetting frmS = new frmServerSetting();
            frmS.ShowDialog();
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void msClinicInfo_Click(object sender, EventArgs e)
        {
            frm_Clinic_information frm = new frm_Clinic_information();
            frm.ShowDialog();
        }

        
    }
}
