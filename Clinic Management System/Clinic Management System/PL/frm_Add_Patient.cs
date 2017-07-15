using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class frm_Add_Patient : Form
    {
        public string state = "add";
        BL.CLS_Patient ptn = new BL.CLS_Patient();
        // variable for gender
        string gender = "";
        string status = "";
        string correct = ""; //To check the form of the email

        public frm_Add_Patient()
        {
            InitializeComponent();
            txtgenderHide.Top = -100;
            txt_status.Top = -100;
        }

        // function for download gender 

        private void gender_download()
        {
            if (rdb_male.Checked == true)
            {

                gender = "Male";
            }
            if (rdb_female.Checked == true)
            {
                gender = "Female";
            }
        }
        private void patient_status()
        {
            if (rdb_Married.Checked == true)
            {

                status = "Married";
            }
            if (rdb_Single.Checked == true)
            {
                status = "Single";
            }
        }

        //methode to empty the fields
        private void empty_fields()
        {
            txt_Patient_Id.Text = "";
            txt_Patient_Name.Text = "";
            txt_email.Text = "";
            rtxt_Adresse.Text = "";
            mTxt_contact_no.Text = "";
            mTxt_contact_no2.Text = "";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_Patient frmp = new frm_Patient();
            gender_download();
            patient_status();

            if (txt_Patient_Id.Text == "" || txt_Patient_Name.Text == "" || txt_email.Text == "" || rtxt_Adresse.Text == "" || mTxt_contact_no.Text == "" || mTxt_contact_no2.Text == "" || correct == "" || status == "" || gender == "")
            {
                MessageBox.Show("يرجى كتابة جميع البيانات  ؟؟");
            }
            else
            {
                if (state == "add")
                {
                    if (correct == "yes")
                    {
                        try
                        {

                            ptn.ADD_PATIENT(txt_Patient_Id.Text, txt_Patient_Name.Text, gender, dtp_Patient_birthday.Value.Date, dtp_Registration_Date.Value.Date, status, rtxt_Adresse.Text, txt_email.Text,
                                    mTxt_contact_no.Text, mTxt_contact_no2.Text);

                            MessageBox.Show("لقد تمة إضافة المريض بنجاح", "عملية الأضافة", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            empty_fields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى  مراجعة البريد الإلكتروني", "انتباه ");
                    }
                    
                }
                else
                {
                    if (correct == "yes")
                    {
                        try
                        {

                            ptn.UPDATE_PATIENT(txt_Patient_Id.Text, txt_Patient_Name.Text, gender, dtp_Patient_birthday.Value.Date, dtp_Registration_Date.Value.Date, status, rtxt_Adresse.Text, txt_email.Text,
                                    mTxt_contact_no.Text, mTxt_contact_no2.Text);

                            MessageBox.Show("تمت عملية االتعديل بنجاح", "عملية التحديث", MessageBoxButtons.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            empty_fields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("يرجى  مراجعة البريد الإلكتروني", "انتباه ");
                    }
                }

            }
            
            frmp.grid_All_Patient.DataSource = ptn.GET_ALL_PATIENT("");

        }

        private void txt_email_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txt_email.ToString(), @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}", RegexOptions.IgnoreCase))
                e.Cancel = true;
            correct = "yes";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            empty_fields();
        }

    }
}
