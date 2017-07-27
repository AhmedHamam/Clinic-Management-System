namespace Clinic_Management_System 
{
    partial class StaffAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StaffLabelGender = new System.Windows.Forms.Label();
            this.StaffLabelSocialState = new System.Windows.Forms.Label();
            this.StaffLabelJob = new System.Windows.Forms.Label();
            this.StaffSocialstate = new System.Windows.Forms.ComboBox();
            this.StaffJob = new System.Windows.Forms.ComboBox();
            this.StaffGender = new System.Windows.Forms.ComboBox();
            this.StaffEmployeeDate = new System.Windows.Forms.DateTimePicker();
            this.StaffBirthDate = new System.Windows.Forms.DateTimePicker();
            this.StaffLabelBirthdate = new System.Windows.Forms.Label();
            this.StaffLabelEmployeedate = new System.Windows.Forms.Label();
            this.StaffEmail = new System.Windows.Forms.TextBox();
            this.StaffLabelEmail = new System.Windows.Forms.Label();
            this.StaffPhoneNumber2 = new System.Windows.Forms.TextBox();
            this.StaffLabelPhonenumber2 = new System.Windows.Forms.Label();
            this.StaffPhoneNumber1 = new System.Windows.Forms.TextBox();
            this.StaffLabelPhonenumber1 = new System.Windows.Forms.Label();
            this.StaffAdress = new System.Windows.Forms.TextBox();
            this.StaffLabeladress = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.StaffLabelName = new System.Windows.Forms.Label();
            this.StaffId = new System.Windows.Forms.TextBox();
            this.StaffLabelId = new System.Windows.Forms.Label();
            this.StaffImage = new System.Windows.Forms.PictureBox();
            this.Staffbtn = new System.Windows.Forms.Button();
            this.AddStaffToolsTip = new System.Windows.Forms.ToolTip(this.components);
            this.EditStaffToolsTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.StaffLabelGender);
            this.groupBox1.Controls.Add(this.StaffLabelSocialState);
            this.groupBox1.Controls.Add(this.StaffLabelJob);
            this.groupBox1.Controls.Add(this.StaffSocialstate);
            this.groupBox1.Controls.Add(this.StaffJob);
            this.groupBox1.Controls.Add(this.StaffGender);
            this.groupBox1.Controls.Add(this.StaffEmployeeDate);
            this.groupBox1.Controls.Add(this.StaffBirthDate);
            this.groupBox1.Controls.Add(this.StaffLabelBirthdate);
            this.groupBox1.Controls.Add(this.StaffLabelEmployeedate);
            this.groupBox1.Controls.Add(this.StaffEmail);
            this.groupBox1.Controls.Add(this.StaffLabelEmail);
            this.groupBox1.Controls.Add(this.StaffPhoneNumber2);
            this.groupBox1.Controls.Add(this.StaffLabelPhonenumber2);
            this.groupBox1.Controls.Add(this.StaffPhoneNumber1);
            this.groupBox1.Controls.Add(this.StaffLabelPhonenumber1);
            this.groupBox1.Controls.Add(this.StaffAdress);
            this.groupBox1.Controls.Add(this.StaffLabeladress);
            this.groupBox1.Controls.Add(this.StaffName);
            this.groupBox1.Controls.Add(this.StaffLabelName);
            this.groupBox1.Controls.Add(this.StaffId);
            this.groupBox1.Controls.Add(this.StaffLabelId);
            this.groupBox1.Controls.Add(this.StaffImage);
            this.groupBox1.Controls.Add(this.Staffbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الموظف";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(6, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "حفظ";
            this.AddStaffToolsTip.SetToolTip(this.button1, "حفظ بياننات الموظف");
            this.EditStaffToolsTip.SetToolTip(this.button1, "حفظ بياننات الموظف");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaffLabelGender
            // 
            this.StaffLabelGender.AutoSize = true;
            this.StaffLabelGender.Location = new System.Drawing.Point(295, 287);
            this.StaffLabelGender.Name = "StaffLabelGender";
            this.StaffLabelGender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelGender.Size = new System.Drawing.Size(60, 23);
            this.StaffLabelGender.TabIndex = 23;
            this.StaffLabelGender.Text = "النوع :";
            // 
            // StaffLabelSocialState
            // 
            this.StaffLabelSocialState.AutoSize = true;
            this.StaffLabelSocialState.Location = new System.Drawing.Point(197, 187);
            this.StaffLabelSocialState.Name = "StaffLabelSocialState";
            this.StaffLabelSocialState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelSocialState.Size = new System.Drawing.Size(158, 23);
            this.StaffLabelSocialState.TabIndex = 22;
            this.StaffLabelSocialState.Text = "الحالة الإجتماعية :";
            // 
            // StaffLabelJob
            // 
            this.StaffLabelJob.AutoSize = true;
            this.StaffLabelJob.Location = new System.Drawing.Point(728, 438);
            this.StaffLabelJob.Name = "StaffLabelJob";
            this.StaffLabelJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelJob.Size = new System.Drawing.Size(82, 23);
            this.StaffLabelJob.TabIndex = 21;
            this.StaffLabelJob.Text = "الوظيفة :";
            // 
            // StaffSocialstate
            // 
            this.StaffSocialstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffSocialstate.FormattingEnabled = true;
            this.StaffSocialstate.Items.AddRange(new object[] {
            "عازب",
            "متزوج",
            "أرمل"});
            this.StaffSocialstate.Location = new System.Drawing.Point(101, 230);
            this.StaffSocialstate.Name = "StaffSocialstate";
            this.StaffSocialstate.Size = new System.Drawing.Size(250, 31);
            this.StaffSocialstate.TabIndex = 8;
            this.EditStaffToolsTip.SetToolTip(this.StaffSocialstate, "أدخل حالة الموظف الإجتماعية");
            this.AddStaffToolsTip.SetToolTip(this.StaffSocialstate, "أدخل حالة الموظف الإجتماعية");
            // 
            // StaffJob
            // 
            this.StaffJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffJob.FormattingEnabled = true;
            this.StaffJob.Items.AddRange(new object[] {
            "مدير",
            "سكرتير",
            "طبيب",
            "ممرض"});
            this.StaffJob.Location = new System.Drawing.Point(361, 430);
            this.StaffJob.Name = "StaffJob";
            this.StaffJob.Size = new System.Drawing.Size(250, 31);
            this.StaffJob.TabIndex = 7;
            this.EditStaffToolsTip.SetToolTip(this.StaffJob, "أدخل تاريخ توظيف للموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffJob, "أدخل وظيفة الموظف");
            // 
            // StaffGender
            // 
            this.StaffGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffGender.FormattingEnabled = true;
            this.StaffGender.Items.AddRange(new object[] {
            "ذكر",
            "أنثى"});
            this.StaffGender.Location = new System.Drawing.Point(101, 329);
            this.StaffGender.Name = "StaffGender";
            this.StaffGender.Size = new System.Drawing.Size(250, 31);
            this.StaffGender.TabIndex = 9;
            this.EditStaffToolsTip.SetToolTip(this.StaffGender, "أدخل نوع الموظف(ذكر , أنثى)");
            this.AddStaffToolsTip.SetToolTip(this.StaffGender, "أدخل نوع الموظف(ذكر , أنثى)");
            // 
            // StaffEmployeeDate
            // 
            this.StaffEmployeeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StaffEmployeeDate.Location = new System.Drawing.Point(361, 380);
            this.StaffEmployeeDate.Name = "StaffEmployeeDate";
            this.StaffEmployeeDate.Size = new System.Drawing.Size(250, 30);
            this.StaffEmployeeDate.TabIndex = 6;
            this.AddStaffToolsTip.SetToolTip(this.StaffEmployeeDate, "أدخل تاريخ توظيف للموظف");
            this.EditStaffToolsTip.SetToolTip(this.StaffEmployeeDate, "أدخل تاريخ توظيف للموظف");
            // 
            // StaffBirthDate
            // 
            this.StaffBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StaffBirthDate.Location = new System.Drawing.Point(361, 330);
            this.StaffBirthDate.MaxDate = new System.DateTime(4017, 7, 17, 0, 0, 0, 0);
            this.StaffBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.StaffBirthDate.Name = "StaffBirthDate";
            this.StaffBirthDate.Size = new System.Drawing.Size(250, 30);
            this.StaffBirthDate.TabIndex = 5;
            this.AddStaffToolsTip.SetToolTip(this.StaffBirthDate, "أدخل تاريخ ميلاد للموظف");
            this.EditStaffToolsTip.SetToolTip(this.StaffBirthDate, "أدخل تاريخ ميلاد للموظف");
            // 
            // StaffLabelBirthdate
            // 
            this.StaffLabelBirthdate.AutoSize = true;
            this.StaffLabelBirthdate.Location = new System.Drawing.Point(694, 337);
            this.StaffLabelBirthdate.Name = "StaffLabelBirthdate";
            this.StaffLabelBirthdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelBirthdate.Size = new System.Drawing.Size(116, 23);
            this.StaffLabelBirthdate.TabIndex = 15;
            this.StaffLabelBirthdate.Text = "تاريخ الميلاد :";
            // 
            // StaffLabelEmployeedate
            // 
            this.StaffLabelEmployeedate.AutoSize = true;
            this.StaffLabelEmployeedate.Location = new System.Drawing.Point(684, 387);
            this.StaffLabelEmployeedate.Name = "StaffLabelEmployeedate";
            this.StaffLabelEmployeedate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelEmployeedate.Size = new System.Drawing.Size(127, 23);
            this.StaffLabelEmployeedate.TabIndex = 14;
            this.StaffLabelEmployeedate.Text = "تاريخ التوظيف :";
            // 
            // StaffEmail
            // 
            this.StaffEmail.Location = new System.Drawing.Point(361, 280);
            this.StaffEmail.Name = "StaffEmail";
            this.StaffEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffEmail.Size = new System.Drawing.Size(250, 30);
            this.StaffEmail.TabIndex = 4;
            this.EditStaffToolsTip.SetToolTip(this.StaffEmail, "أدخل بريد الموظف الإلكتروني");
            this.AddStaffToolsTip.SetToolTip(this.StaffEmail, "أدخل بريد الموظف الإلكتروني");
            // 
            // StaffLabelEmail
            // 
            this.StaffLabelEmail.AutoSize = true;
            this.StaffLabelEmail.Location = new System.Drawing.Point(662, 287);
            this.StaffLabelEmail.Name = "StaffLabelEmail";
            this.StaffLabelEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelEmail.Size = new System.Drawing.Size(148, 23);
            this.StaffLabelEmail.TabIndex = 12;
            this.StaffLabelEmail.Text = "البريد الإلكتروني :";
            // 
            // StaffPhoneNumber2
            // 
            this.StaffPhoneNumber2.Location = new System.Drawing.Point(361, 230);
            this.StaffPhoneNumber2.Name = "StaffPhoneNumber2";
            this.StaffPhoneNumber2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffPhoneNumber2.Size = new System.Drawing.Size(250, 30);
            this.StaffPhoneNumber2.TabIndex = 11;
            this.EditStaffToolsTip.SetToolTip(this.StaffPhoneNumber2, "أدخل رقم الهاتف الثاني للموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffPhoneNumber2, "أدخل رقم الهاتف الثاني للموظف");
            // 
            // StaffLabelPhonenumber2
            // 
            this.StaffLabelPhonenumber2.AutoSize = true;
            this.StaffLabelPhonenumber2.Location = new System.Drawing.Point(694, 237);
            this.StaffLabelPhonenumber2.Name = "StaffLabelPhonenumber2";
            this.StaffLabelPhonenumber2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelPhonenumber2.Size = new System.Drawing.Size(122, 23);
            this.StaffLabelPhonenumber2.TabIndex = 10;
            this.StaffLabelPhonenumber2.Text = "رقم الهاتف 2 :";
            // 
            // StaffPhoneNumber1
            // 
            this.StaffPhoneNumber1.Location = new System.Drawing.Point(361, 180);
            this.StaffPhoneNumber1.Name = "StaffPhoneNumber1";
            this.StaffPhoneNumber1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffPhoneNumber1.Size = new System.Drawing.Size(250, 30);
            this.StaffPhoneNumber1.TabIndex = 3;
            this.EditStaffToolsTip.SetToolTip(this.StaffPhoneNumber1, "أدخل رقم الهاتف الأول للموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffPhoneNumber1, "أدخل رقم الهاتف الأول للموظف");
            // 
            // StaffLabelPhonenumber1
            // 
            this.StaffLabelPhonenumber1.AutoSize = true;
            this.StaffLabelPhonenumber1.Location = new System.Drawing.Point(688, 187);
            this.StaffLabelPhonenumber1.Name = "StaffLabelPhonenumber1";
            this.StaffLabelPhonenumber1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelPhonenumber1.Size = new System.Drawing.Size(122, 23);
            this.StaffLabelPhonenumber1.TabIndex = 8;
            this.StaffLabelPhonenumber1.Text = "رقم الهاتف 1 :";
            // 
            // StaffAdress
            // 
            this.StaffAdress.Location = new System.Drawing.Point(361, 130);
            this.StaffAdress.Name = "StaffAdress";
            this.StaffAdress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffAdress.Size = new System.Drawing.Size(250, 30);
            this.StaffAdress.TabIndex = 2;
            this.EditStaffToolsTip.SetToolTip(this.StaffAdress, "أدخل عنوان الموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffAdress, "أدخل عنوان الموظف");
            // 
            // StaffLabeladress
            // 
            this.StaffLabeladress.AutoSize = true;
            this.StaffLabeladress.Location = new System.Drawing.Point(735, 137);
            this.StaffLabeladress.Name = "StaffLabeladress";
            this.StaffLabeladress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabeladress.Size = new System.Drawing.Size(75, 23);
            this.StaffLabeladress.TabIndex = 6;
            this.StaffLabeladress.Text = "العنوان :";
            // 
            // StaffName
            // 
            this.StaffName.Location = new System.Drawing.Point(361, 80);
            this.StaffName.Name = "StaffName";
            this.StaffName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffName.Size = new System.Drawing.Size(250, 30);
            this.StaffName.TabIndex = 1;
            this.EditStaffToolsTip.SetToolTip(this.StaffName, "اسم الموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffName, "أدخل اسم بالموظف");
            // 
            // StaffLabelName
            // 
            this.StaffLabelName.AutoSize = true;
            this.StaffLabelName.Location = new System.Drawing.Point(684, 87);
            this.StaffLabelName.Name = "StaffLabelName";
            this.StaffLabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelName.Size = new System.Drawing.Size(126, 23);
            this.StaffLabelName.TabIndex = 4;
            this.StaffLabelName.Text = "أسم الموظف :";
            // 
            // StaffId
            // 
            this.StaffId.Location = new System.Drawing.Point(361, 28);
            this.StaffId.Name = "StaffId";
            this.StaffId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffId.Size = new System.Drawing.Size(250, 30);
            this.StaffId.TabIndex = 0;
            this.EditStaffToolsTip.SetToolTip(this.StaffId, "كود الموظف");
            this.AddStaffToolsTip.SetToolTip(this.StaffId, "أدخل كود الموظف");
            // 
            // StaffLabelId
            // 
            this.StaffLabelId.AutoSize = true;
            this.StaffLabelId.Location = new System.Drawing.Point(695, 35);
            this.StaffLabelId.Name = "StaffLabelId";
            this.StaffLabelId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StaffLabelId.Size = new System.Drawing.Size(115, 23);
            this.StaffLabelId.TabIndex = 2;
            this.StaffLabelId.Text = "كود الموظف :";
            // 
            // StaffImage
            // 
            this.StaffImage.Image = global::Clinic_Management_System.Properties.Resources.person_male;
            this.StaffImage.Location = new System.Drawing.Point(6, 29);
            this.StaffImage.Name = "StaffImage";
            this.StaffImage.Size = new System.Drawing.Size(164, 164);
            this.StaffImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StaffImage.TabIndex = 1;
            this.StaffImage.TabStop = false;
            // 
            // Staffbtn
            // 
            this.Staffbtn.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Staffbtn.Location = new System.Drawing.Point(6, 199);
            this.Staffbtn.Name = "Staffbtn";
            this.Staffbtn.Size = new System.Drawing.Size(164, 22);
            this.Staffbtn.TabIndex = 10;
            this.Staffbtn.Text = "تعيين صوره";
            this.AddStaffToolsTip.SetToolTip(this.Staffbtn, "قم بتعيين صورة للموظف ");
            this.EditStaffToolsTip.SetToolTip(this.Staffbtn, "قم بتعيين صورة للموظف ");
            this.Staffbtn.UseVisualStyleBackColor = true;
            this.Staffbtn.Click += new System.EventHandler(this.Staffbtn_Click);
            // 
            // AddStaffToolsTip
            // 
            this.AddStaffToolsTip.AutomaticDelay = 250;
            this.AddStaffToolsTip.AutoPopDelay = 5000;
            this.AddStaffToolsTip.InitialDelay = 250;
            this.AddStaffToolsTip.IsBalloon = true;
            this.AddStaffToolsTip.ReshowDelay = 50;
            // 
            // EditStaffToolsTip
            // 
            this.EditStaffToolsTip.AutomaticDelay = 250;
            this.EditStaffToolsTip.AutoPopDelay = 5000;
            this.EditStaffToolsTip.InitialDelay = 250;
            this.EditStaffToolsTip.IsBalloon = true;
            this.EditStaffToolsTip.ReshowDelay = 50;
            // 
            // StaffAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 511);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StaffAddForm";
            this.Text = "StaffAddForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox StaffEmail;
        private System.Windows.Forms.Label StaffLabelEmail;
        private System.Windows.Forms.TextBox StaffPhoneNumber2;
        private System.Windows.Forms.Label StaffLabelPhonenumber2;
        private System.Windows.Forms.TextBox StaffPhoneNumber1;
        private System.Windows.Forms.Label StaffLabelPhonenumber1;
        private System.Windows.Forms.TextBox StaffAdress;
        private System.Windows.Forms.Label StaffLabeladress;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label StaffLabelName;
        private System.Windows.Forms.TextBox StaffId;
        private System.Windows.Forms.Label StaffLabelId;
        private System.Windows.Forms.PictureBox StaffImage;
        private System.Windows.Forms.Button Staffbtn;
        private System.Windows.Forms.Label StaffLabelGender;
        private System.Windows.Forms.Label StaffLabelSocialState;
        private System.Windows.Forms.Label StaffLabelJob;
        private System.Windows.Forms.ComboBox StaffSocialstate;
        private System.Windows.Forms.ComboBox StaffJob;
        private System.Windows.Forms.ComboBox StaffGender;
        private System.Windows.Forms.DateTimePicker StaffEmployeeDate;
        private System.Windows.Forms.DateTimePicker StaffBirthDate;
        private System.Windows.Forms.Label StaffLabelBirthdate;
        private System.Windows.Forms.Label StaffLabelEmployeedate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip AddStaffToolsTip;
        private System.Windows.Forms.ToolTip EditStaffToolsTip;
    }
}