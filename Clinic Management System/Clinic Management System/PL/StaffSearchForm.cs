using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clinic_Management_System 
{
    public partial class StaffSearchForm : Form
    {
        public static StaffSearchForm stSearchForm;
        public clsStaff Staffs = new clsStaff();
        MoafaMessageBox msg = new MoafaMessageBox();
        public StaffSearchForm()
        {
            InitializeComponent();
            
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            StaffAddForm SAF = new StaffAddForm(false);
            SAF.ShowDialog();
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            EditStaff();
        }

        private void DeleteStaffbtn_Click(object sender, EventArgs e)
        {
            DelteStaff();
        }

        private void SearchStaffBox_TextChanged(object sender, EventArgs e)
        {
            SearchStaff();
        }
        private void RowMenuEdit_Clicked(object sender, EventArgs e)
        {
            EditStaff();
        }
        private void RowMenuDelete_Clicked(object sender, EventArgs e)
        {
            DelteStaff();
        }
        private void EditStaff()
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                DataGridViewRow DGVR = StaffTable.CurrentRow;
                StaffAddForm SAF = new StaffAddForm(true, int.Parse(DGVR.Cells["الكود"].Value.ToString()), DGVR.Cells["اسم الموظف"].Value.ToString(), DGVR.Cells["العنوان"].Value.ToString(), int.Parse(DGVR.Cells["رقم الهاتف 1"].Value.ToString()), int.Parse(DGVR.Cells["رقم الهاتف 2"].Value.ToString()), DGVR.Cells["البريد الإلكتروني"].Value.ToString(), DGVR.Cells["تاريخ الميلاد"].Value.ToString(), DGVR.Cells["تاريخ التوظيف"].Value.ToString(), DGVR.Cells["الوظيفة"].Value.ToString(), DGVR.Cells["النوع"].Value.ToString(), DGVR.Cells["الحالة الإجتماعية"].Value.ToString(), Staffs.SP_Get_Image_Staff(int.Parse(DGVR.Cells["الكود"].Value.ToString())));
                SAF.ShowDialog();
            }
        }
        private void DelteStaff()
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("من جدول الموظفين ؟ '" + StaffTable.CurrentRow.Cells["اسم الموظف"].Value + "' هل أنت متأكد أنك تريد حذف", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Staffs.SP_Delete_Staff(int.Parse(StaffTable.CurrentRow.Cells["الكود"].Value.ToString()));
                        msg.MoafaShow("تمت عملية الحذف بنجاح", MoafaIcon.Success);
                        //MessageBox.Show("تمت عملية الحذف بنجاح", "حُذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("! '" + StaffTable.SelectedRows[0].Cells[1].Value + "'لم نستطع مسح", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    StaffTable.DataSource = Staffs.SP_Get_Staff_Table();
                }
            }
        }
        private void SearchStaff()
        {
            StaffTable.DataSource = Staffs.SP_Search_Staff(SearchStaffBox.Text);
        }
        private void PrintStaff()
        {

        }
        private void PrintAllStaff()
        {

        }
        private void StaffSearchForm_Load(object sender, EventArgs e)
        {
            stSearchForm = this;
            StaffTable.DataSource = Staffs.SP_Get_Staff_Table();
            SearchStaffToolsTip.ToolTipIcon = ToolTipIcon.Info;
        }

        private void SearchStaffBtn_Click(object sender, EventArgs e)
        {
            SearchStaff();
        }

        private void PrintStaffBtn_Click(object sender, EventArgs e)
        {
            PrintStaff();
        }

        private void PrintAllStaffBtn_Click(object sender, EventArgs e)
        {
            PrintAllStaff();
        }

        private void RowMenuPrint_Click(object sender, EventArgs e)
        {
            PrintStaff();
        }
    }
}