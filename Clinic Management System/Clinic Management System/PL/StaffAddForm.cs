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
        public StaffAddForm(bool edit ,int id , string name , string adress, int contactno1 , int contactno2 , string email , string birthdate , string employeedate , string job , string gender , string socialstate , Image picture)
        {
            InitializeComponent();
            Edit = edit;
            if (Edit == true)
            {
                this.id = id;
                this.name = name;
                StaffName.ReadOnly = true;
                StaffId.ReadOnly = true;
                EditStaffToolsTip.ToolTipIcon = ToolTipIcon.Info;
                AddStaffToolsTip.Active = false;
                StaffName.Text = name;
                StaffId.Text = id.ToString();
                StaffAdress.TabIndex = 0;
                StaffAdress.Text = adress;
                StaffPhoneNumber1.Text = contactno1.ToString();
                StaffPhoneNumber2.Text = contactno2.ToString();
                StaffEmail.Text = email;
                StaffJob.SelectedItem = job;
                StaffGender.SelectedItem = gender;
                StaffSocialstate.SelectedItem = socialstate;
                StaffBirthDate.Text = birthdate;
                StaffEmployeeDate.Text = employeedate;
                StaffImage.Image = picture;
                this.Text = "نموذج تعديل الموظف";
            }

        }
        public StaffAddForm(bool edit)
        {
            InitializeComponent();
            Edit = edit;
            StaffGender.SelectedIndex = 0;
            StaffJob.SelectedIndex = 0;
            StaffSocialstate.SelectedIndex = 0;
            this.Text = "نموذج إضافة الموظف";
            AddStaffToolsTip.ToolTipIcon = ToolTipIcon.Info;
            EditStaffToolsTip.Active = false;
        }
        private void Staffbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.InitialDirectory = "C:/Users/"+ Environment.UserName + "/Documents";
            filedialog.Title = "تعيين صورة موظف";
            filedialog.Filter = " PNG | *.png;| JPG | *.jpg; *.jpeg; | BMB | *.bmp; | GIF | *.gif;";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                StaffImage.Image = Image.FromFile(filedialog.FileName);
            }
            filedialog.Dispose();
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
                                if (StaffImage.Image != null)
                                {
                                    int staffphonenumber1;
                                    if (int.TryParse(StaffPhoneNumber1.Text, out staffphonenumber1) == true)
                                    {
                                        if (StaffPhoneNumber2.Text == "")
                                        {
                                            StaffPhoneNumber2.Text = "0";
                                        }
                                        int staffphonenumber2;
                                        if (int.TryParse(StaffPhoneNumber2.Text, out staffphonenumber2) == true)
                                        {
                                            int staffid;
                                            if (int.TryParse(StaffId.Text, out staffid) == true)
                                            {
                                                if (Edit == false)
                                                {
                                                    //===================================================
                                                    if (staffff.CheckExists(staffid, StaffName.Text).Rows.Count <= 0)
                                                    {
                                                        try
                                                        {
                                                            staffff.SP_Insert_Staff(int.Parse(StaffId.Text), StaffName.Text, staffphonenumber1, staffphonenumber2, StaffAdress.Text, StaffEmail.Text, StaffBirthDate.Value, StaffEmployeeDate.Value, StaffJob.SelectedItem.ToString(), StaffSocialstate.SelectedItem.ToString(), StaffGender.SelectedItem.ToString(), Connection.ConvertImageToBytes(StaffImage.Image));
                                                            MessageBox.Show("! تمت الإضافة بنجاح", "أُضيف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            StaffSearchForm.stSearchForm.StaffTable.DataSource = staffff.SP_Get_Staff_Table();
                                                            this.Close();

                                                        }
                                                        catch
                                                        {
                                                            MessageBox.Show("! لم نستطع إضافة موظف", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("! تم إضافة اسم أو كود الموظف مسبقاً", "اسم أو كود خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                    //===================================================
                                                }
                                                else
                                                {
                                                    try
                                                    {
                                                        staffff.SP_Edit_Staff(int.Parse(StaffId.Text), staffphonenumber1, staffphonenumber2, StaffAdress.Text, StaffEmail.Text, StaffBirthDate.Value, StaffEmployeeDate.Value, StaffJob.SelectedItem.ToString(), StaffSocialstate.SelectedItem.ToString(), StaffGender.SelectedItem.ToString(), Connection.ConvertImageToBytes(StaffImage.Image));
                                                        StaffSearchForm.stSearchForm.StaffTable.DataSource = staffff.SP_Get_Staff_Table();
                                                        MessageBox.Show("! تم تعديل بيانات الموظف بنجاح", "عُدل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        this.Close();
                                                    }
                                                    catch
                                                    {
                                                        MessageBox.Show("لم نتمكن من تعديل بيانات الموظف", "فشلت العملية", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("! من فضلك أدخل كود الموظف صحيح", "كود موظف خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("! من فضلك أدخل رقم الهاتف الثاني للموظف صحيحاً", "رقم الهاتف الثاني للموظف خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("! من فضلك أدخل رقم الهاتف الأول للموظف صحيحاً", "كود رقم الهاتف الأول للموظف خاطئ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("! من فضلك أدخل صورة الموظف", "لم يتم إدخال صورة الموظف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("! من فضلك أدخل البريد الموظف الإلكتروني", "لم يتم إدخال لبريد الموظف الإلكتروني", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("! من فضلك أدخل رقم هاتف الموظف", "لم يتم إدخال رقم هاتف الموظف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("! من فضلك أدخل عنوان الموظف", "لم يتم إدخال عنوان الموظف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("! من فضلك أدخل اسم الموظف", "لم يتم إدخال اسم الموظف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("! من فضلك أدخل كود الموظف", "لم يتم إدخال كود الموظف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}