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
    public partial class StaffAddForm : Form
    {
        public Image picture;
        public bool Edit;
        public int id;
        public string name;
        public StaffAddForm(bool edit ,int id , string name , string adress, string contactno1 , string contactno2 , string email , string birthdate , string employeedate , string job , string gender , string socialstate , Image picture)
        {
            InitializeComponent();
            Edit = edit;
            if (Edit == true)
            {
                this.id = id;
                this.name = name;
                StaffName.ReadOnly = true;
                StaffId.ReadOnly = true;
                StaffName.Text = name;
                StaffId.Text = id.ToString();
                StaffAdress.TabIndex = 0;
                StaffAdress.Text = adress;
                StaffPhoneNumber1.Text = contactno1;
                StaffPhoneNumber2.Text = contactno2;
                StaffEmail.Text = email;
                StaffJob.SelectedItem = job;
                StaffGender.SelectedItem = gender;
                StaffSocialstate.SelectedItem = socialstate;
                StaffBirthDate.Text = birthdate;
                StaffEmployeeDate.Text = employeedate;
                StaffImage.Image = picture;
            }

        }
        public StaffAddForm(bool edit)
        {
            InitializeComponent();
            Edit = edit;
            StaffGender.SelectedIndex = 0;
            StaffJob.SelectedIndex = 0;
            StaffSocialstate.SelectedIndex = 0;
        }
        private void Staffbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                picture = Image.FromFile(filedialog.FileName);
            }
            filedialog.Dispose();
            StaffImage.Image = picture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsStaff staffff = new clsStaff();
            if (StaffId.Text != "")
            {
                if (StaffName.Text != "")
                {
                    if (StaffAdress.Text != "")
                    {
                        if (StaffPhoneNumber1.Text != "")
                        {
                            if (StaffEmail.Text != "")
                            {
                                if (picture != null)
                                {
                                    int staffid;
                                    if (int.TryParse(StaffId.Text, out staffid) == true)
                                    {
                                        if (Edit == false)
                                        {
                                            //===================================================
                                            if (staffff.CheckExists(staffid , StaffName.Text).Rows.Count <= 0)
                                            {
                                                try
                                                {
                                                    staffff.SP_Insert_Staff(int.Parse(StaffId.Text), StaffName.Text, StaffPhoneNumber1.Text, StaffPhoneNumber2.Text, StaffAdress.Text, StaffEmail.Text, StaffBirthDate.Value, StaffEmployeeDate.Value, StaffJob.SelectedValue.ToString(), StaffSocialstate.SelectedValue.ToString(), StaffGender.SelectedValue.ToString(), Connection.ConvertImageToBytes(StaffImage.Image));
                                                    MessageBox.Show("New staff added successfully !", "New staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    StaffSearchForm.stSearchForm.StaffTable.DataSource = staffff.SP_Get_Staff_Table();
                                                    
                                                }
                                                catch
                                                {
                                                    MessageBox.Show("couldn't add staff", "Invalid opreation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("the staff id or name was already taken", "Invalid id or name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            //===================================================
                                        }
                                        else
                                        {
                                            try
                                            {
                                                staffff.SP_Edit_Staff(int.Parse(StaffId.Text), StaffPhoneNumber1.Text, StaffPhoneNumber2.Text, StaffAdress.Text, StaffEmail.Text, StaffBirthDate.Value, StaffEmployeeDate.Value, StaffJob.SelectedValue.ToString(), StaffSocialstate.SelectedValue.ToString(), StaffGender.SelectedValue.ToString(), Connection.ConvertImageToBytes(StaffImage.Image));
                                                StaffSearchForm.stSearchForm.StaffTable.DataSource = staffff.SP_Get_Staff_Table();
                                                MessageBox.Show("Staff Edited successfully !", "Staff Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            catch
                                            {
                                                MessageBox.Show("couldn't Edit staff", "Invalid opreation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Please Insert a valid staff id", "Invalid staff id", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please Insert valid a staff picture;", "Invalid staff picture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please Insert valid a staff emai;", "Invalid staff emai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Insert valid a staff contact number", "Invalid staff contact number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Insert valid a staff adress", "Invalid staff adress", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please Insert valid a staff name", "Invalid staff name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Insert valid a staff id", "Invalid staff id", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
