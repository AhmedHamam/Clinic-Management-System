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
    public partial class frm_Patient : Form
    {
        frm_Add_Patient frm = new frm_Add_Patient();
        BL.CLS_Patient ptn = new BL.CLS_Patient();

        // variable for gender
        string gender = "";
        string status = "";
        public frm_Patient()
        {
            InitializeComponent();
            grid_All_Patient.DataSource = ptn.GET_ALL_PATIENT("");

            frm.txtgenderHide.Top = -100;
            frm.txt_status.Top = -100;

            txt_search.GotFocus += new EventHandler(txt_search_GotFocus);
            txt_search.Leave += new EventHandler(txt_search_leave);
        }

        public void txt_search_GotFocus(object sender, EventArgs e)
        {
            txt_search.Text = "";
            txt_search.GotFocus -= txt_search_GotFocus;
        }
        public void txt_search_leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_search.Text))
            {
                txt_search.Text = "بحث";
                txt_search.GotFocus += new EventHandler(txt_search_GotFocus);
            }
        }


        private void Refresh_Rdbgender()
        {
            //Refresh the radion button when editing in the records
            if (frm.txtgenderHide.Text == "Male")
                frm.rdb_male.Checked = true;
            else frm.rdb_female.Checked = true;
        }
        //-----------------------------------------
        private void Refresh_Rdbstatus()
        {
           
            if (frm.txt_status.Text == "Single")
                frm.rdb_Single.Checked = true;
            else frm.rdb_Married.Checked = true;
        }
        // function for download gender 

        private void gender_download()
        {
            if (frm.rdb_male.Checked == true)
            {

                gender = "Male";
            }
            if (frm.rdb_female.Checked == true)
            {
                gender = "Female";
            }
        }
        private void patient_status()
        {
            if (frm.rdb_Married.Checked == true)
            {

                status = "Married";
            }
            if (frm.rdb_Single.Checked == true)
            {
                status = "Single";
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_Add_Patient new_ptn =new frm_Add_Patient();
            new_ptn.ShowDialog();
        }

        private void btn_Modify_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------
            frm.txtgenderHide.Text = this.grid_All_Patient.CurrentRow.Cells[2].Value.ToString();
            frm.txt_status.Text = this.grid_All_Patient.CurrentRow.Cells[5].Value.ToString();
            //-------------------------------------------------------------------------------------------
            Refresh_Rdbgender();
            Refresh_Rdbstatus();
            frm.txt_Patient_Id.Text = this.grid_All_Patient.CurrentRow.Cells[0].Value.ToString();
            frm.txt_Patient_Name.Text = this.grid_All_Patient.CurrentRow.Cells[1].Value.ToString();
            gender = this.grid_All_Patient.CurrentRow.Cells[2].Value.ToString();
            frm.dtp_Patient_birthday.Value = Convert.ToDateTime(this.grid_All_Patient.CurrentRow.Cells[3].Value.ToString());
            frm.dtp_Registration_Date.Value = Convert.ToDateTime(this.grid_All_Patient.CurrentRow.Cells[4].Value.ToString());
            status = this.grid_All_Patient.CurrentRow.Cells[5].Value.ToString();
            frm.rtxt_Adresse.Text = this.grid_All_Patient.CurrentRow.Cells[6].Value.ToString();
            frm.txt_email.Text = this.grid_All_Patient.CurrentRow.Cells[7].Value.ToString();
            frm.mTxt_contact_no.Text = this.grid_All_Patient.CurrentRow.Cells[8].Value.ToString();
            frm.mTxt_contact_no2.Text = this.grid_All_Patient.CurrentRow.Cells[9].Value.ToString();
            frm.Text = "تحديث المريض : " + this.grid_All_Patient.CurrentRow.Cells[1].Value.ToString();
            frm.state = "update";
            frm.txt_Patient_Id.ReadOnly = true;
            frm.btnAdd.Text = "تحديث";
            frm.ShowDialog();
            grid_All_Patient.DataSource = ptn.GET_ALL_PATIENT("");
        }

        private void frm_Patient_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريد فعلا حذف المريض المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ptn.Delete_PATIENT(this.grid_All_Patient.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_All_Patient.DataSource = ptn.GET_ALL_PATIENT("");
                }
                else
                {
                    MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_search.Text!="")
            {
                grid_All_Patient.DataSource = ptn.GET_ALL_PATIENT(txt_search.Text);
            }
            
        }
    }
}
