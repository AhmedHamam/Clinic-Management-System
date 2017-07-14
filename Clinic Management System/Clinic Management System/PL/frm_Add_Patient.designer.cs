namespace Clinic_Management_System
{
    partial class frm_Add_Patient
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mTxt_contact_no = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mTxt_contact_no2 = new System.Windows.Forms.MaskedTextBox();
            this.rtxt_Adresse = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtp_Registration_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Patient_Name = new System.Windows.Forms.TextBox();
            this.txt_Patient_Id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_female = new System.Windows.Forms.RadioButton();
            this.rdb_male = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Patient_birthday = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_Married = new System.Windows.Forms.RadioButton();
            this.rdb_Single = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtgenderHide = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(15, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(930, 57);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "إضافة مريض ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(32, 152);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(241, 30);
            this.txt_email.TabIndex = 12;
            this.txt_email.Validating += new System.ComponentModel.CancelEventHandler(this.txt_email_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "الايميل :";
            // 
            // mTxt_contact_no
            // 
            this.mTxt_contact_no.Location = new System.Drawing.Point(32, 188);
            this.mTxt_contact_no.Mask = "0000-000000000";
            this.mTxt_contact_no.Name = "mTxt_contact_no";
            this.mTxt_contact_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTxt_contact_no.Size = new System.Drawing.Size(241, 30);
            this.mTxt_contact_no.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "رقم الهاتف :";
            // 
            // mTxt_contact_no2
            // 
            this.mTxt_contact_no2.Location = new System.Drawing.Point(32, 234);
            this.mTxt_contact_no2.Mask = "0000-000000000";
            this.mTxt_contact_no2.Name = "mTxt_contact_no2";
            this.mTxt_contact_no2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTxt_contact_no2.Size = new System.Drawing.Size(241, 30);
            this.mTxt_contact_no2.TabIndex = 8;
            // 
            // rtxt_Adresse
            // 
            this.rtxt_Adresse.Location = new System.Drawing.Point(32, 50);
            this.rtxt_Adresse.Name = "rtxt_Adresse";
            this.rtxt_Adresse.Size = new System.Drawing.Size(241, 93);
            this.rtxt_Adresse.TabIndex = 4;
            this.rtxt_Adresse.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "رقم الهاتف (2) :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 57);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "العنوان :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_email);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.mTxt_contact_no);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mTxt_contact_no2);
            this.groupBox4.Controls.Add(this.rtxt_Adresse);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.groupBox4.Location = new System.Drawing.Point(15, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox4.Size = new System.Drawing.Size(462, 289);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "معلومات الاتصال بالمريض";
            // 
            // dtp_Registration_Date
            // 
            this.dtp_Registration_Date.Location = new System.Drawing.Point(287, 29);
            this.dtp_Registration_Date.Name = "dtp_Registration_Date";
            this.dtp_Registration_Date.Size = new System.Drawing.Size(356, 30);
            this.dtp_Registration_Date.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtp_Registration_Date);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(15, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(930, 82);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تاريخ تسجيل المريض";
            // 
            // txt_Patient_Name
            // 
            this.txt_Patient_Name.Location = new System.Drawing.Point(36, 96);
            this.txt_Patient_Name.Name = "txt_Patient_Name";
            this.txt_Patient_Name.Size = new System.Drawing.Size(229, 30);
            this.txt_Patient_Name.TabIndex = 6;
            // 
            // txt_Patient_Id
            // 
            this.txt_Patient_Id.Location = new System.Drawing.Point(36, 50);
            this.txt_Patient_Id.Name = "txt_Patient_Id";
            this.txt_Patient_Id.Size = new System.Drawing.Size(229, 30);
            this.txt_Patient_Id.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ الميلاد  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "نوع المريض :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المريض(ة) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "معرف المريض(ة) :";
            // 
            // rdb_female
            // 
            this.rdb_female.AutoSize = true;
            this.rdb_female.Location = new System.Drawing.Point(87, 2);
            this.rdb_female.Name = "rdb_female";
            this.rdb_female.Size = new System.Drawing.Size(64, 27);
            this.rdb_female.TabIndex = 1;
            this.rdb_female.TabStop = true;
            this.rdb_female.Text = "أنثى";
            this.rdb_female.UseVisualStyleBackColor = true;
            // 
            // rdb_male
            // 
            this.rdb_male.AutoSize = true;
            this.rdb_male.Location = new System.Drawing.Point(172, 2);
            this.rdb_male.Name = "rdb_male";
            this.rdb_male.Size = new System.Drawing.Size(54, 27);
            this.rdb_male.TabIndex = 0;
            this.rdb_male.TabStop = true;
            this.rdb_male.Text = "ذكر";
            this.rdb_male.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "الحالة الاجتماعية :";
            // 
            // dtp_Patient_birthday
            // 
            this.dtp_Patient_birthday.Location = new System.Drawing.Point(36, 188);
            this.dtp_Patient_birthday.Name = "dtp_Patient_birthday";
            this.dtp_Patient_birthday.Size = new System.Drawing.Size(229, 30);
            this.dtp_Patient_birthday.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_female);
            this.panel1.Controls.Add(this.rdb_male);
            this.panel1.Location = new System.Drawing.Point(36, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 30);
            this.panel1.TabIndex = 8;
            // 
            // rdb_Married
            // 
            this.rdb_Married.AutoSize = true;
            this.rdb_Married.Location = new System.Drawing.Point(20, 2);
            this.rdb_Married.Name = "rdb_Married";
            this.rdb_Married.Size = new System.Drawing.Size(96, 27);
            this.rdb_Married.TabIndex = 1;
            this.rdb_Married.TabStop = true;
            this.rdb_Married.Text = "متزوج(ة)";
            this.rdb_Married.UseVisualStyleBackColor = true;
            // 
            // rdb_Single
            // 
            this.rdb_Single.AutoSize = true;
            this.rdb_Single.Location = new System.Drawing.Point(136, 2);
            this.rdb_Single.Name = "rdb_Single";
            this.rdb_Single.Size = new System.Drawing.Size(90, 27);
            this.rdb_Single.TabIndex = 0;
            this.rdb_Single.TabStop = true;
            this.rdb_Single.Text = "عازب(ة)";
            this.rdb_Single.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdb_Married);
            this.panel2.Controls.Add(this.rdb_Single);
            this.panel2.Location = new System.Drawing.Point(36, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 30);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtp_Patient_birthday);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txt_Patient_Name);
            this.groupBox1.Controls.Add(this.txt_Patient_Id);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(483, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(462, 289);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المريض";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(15, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(930, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = "تفريغ الحقول";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtgenderHide
            // 
            this.txtgenderHide.Location = new System.Drawing.Point(47, 12);
            this.txtgenderHide.Name = "txtgenderHide";
            this.txtgenderHide.Size = new System.Drawing.Size(100, 20);
            this.txtgenderHide.TabIndex = 18;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(153, 12);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(100, 20);
            this.txt_status.TabIndex = 19;
            // 
            // frm_Add_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txtgenderHide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frm_Add_Patient";
            this.Text = "إضافة مريض جديد";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.MaskedTextBox mTxt_contact_no;
        public System.Windows.Forms.MaskedTextBox mTxt_contact_no2;
        public System.Windows.Forms.RichTextBox rtxt_Adresse;
        public System.Windows.Forms.DateTimePicker dtp_Registration_Date;
        public System.Windows.Forms.TextBox txt_Patient_Name;
        public System.Windows.Forms.TextBox txt_Patient_Id;
        public System.Windows.Forms.DateTimePicker dtp_Patient_birthday;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton rdb_female;
        public System.Windows.Forms.RadioButton rdb_male;
        public System.Windows.Forms.RadioButton rdb_Married;
        public System.Windows.Forms.RadioButton rdb_Single;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.TextBox txtgenderHide;
        public System.Windows.Forms.TextBox txt_status;
    }
}