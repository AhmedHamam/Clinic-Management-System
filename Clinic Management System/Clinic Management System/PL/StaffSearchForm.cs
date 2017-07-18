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
        public StaffSearchForm()
        {
            InitializeComponent();
            stSearchForm = this;
            StaffTable.DataSource = Staffs.SP_Get_Staff_Table();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            StaffAddForm SAF = new StaffAddForm(false);
            SAF.ShowDialog();
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                DataGridViewRow DGVR = StaffTable.CurrentRow;
                StaffAddForm SAF = new StaffAddForm(true, int.Parse(DGVR.Cells[0].Value.ToString()) , DGVR.Cells[1].Value.ToString() , DGVR.Cells[2].Value.ToString() , DGVR.Cells[3].Value.ToString() , DGVR.Cells[4].Value.ToString() , DGVR.Cells[5].Value.ToString() , DGVR.Cells[6].Value.ToString() , DGVR.Cells[7].Value.ToString() , DGVR.Cells[8].Value.ToString() , DGVR.Cells[9].Value.ToString() , DGVR.Cells[10].Value.ToString() , Staffs.SP_Get_Image_Staff(int.Parse(DGVR.Cells[0].Value.ToString())));
                SAF.ShowDialog();
            }
        }

        private void DeleteStaffbtn_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete '" + StaffTable.SelectedRows[0].Cells[1].Value + "' from staff table ?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Staffs.SP_Delete_Staff(int.Parse(StaffTable.SelectedCells[0].Value.ToString()));
                        MessageBox.Show("Deleted succsesfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Couldn't delete '" + StaffTable.SelectedRows[0].Cells[1].Value + "'.", "Invalid opearation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void SearchStaffBox_TextChanged(object sender, EventArgs e)
        {
            StaffTable.DataSource = Staffs.SP_Search_Staff(SearchStaffBox.Text);
        }
        public void StaffAddForm_FormClosed(object sender , FormClosedEventArgs e)
        {

        }
    }
}
