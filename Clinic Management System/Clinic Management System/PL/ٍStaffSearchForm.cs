using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Clinic_Management_System.PL
{
    public partial class StaffSearchForm : Form
    {
        public static bool Edit = false;
        public clsStaff Staffs = new clsStaff();
        public StaffSearchForm()
        {
            InitializeComponent();
            StaffTable.DataSource = Staffs.GetStaffTable();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
                StaffAddForm SAF = new StaffAddForm(false , 1 , "");
                SAF.Show();
        }

        private void EditStaffBtn_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                StaffAddForm SAF = new StaffAddForm(true , 1 , "");
                SAF.Show();
                StaffTable.DataSource = Staffs.GetStaffTable();
            }
        }

        private void DeleteStaffbtn_Click(object sender, EventArgs e)
        {
            if (StaffTable.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete" + StaffTable.SelectedRows[0].Cells[1].Value + "from staff table ?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Staffs.DeleteRow(int.Parse(StaffTable.SelectedCells[0].Value.ToString()));

                }
                MessageBox.Show("Deleted succsesfully !", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshStaffBtn_Click(object sender, EventArgs e)
        {
            StaffTable.DataSource = Staffs.GetStaffTable();
        }
    }
}
