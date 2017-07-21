namespace Clinic_Management_System
{
    partial class Main_Form
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btnManageStaff = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.btnPatinet = new System.Windows.Forms.Button();
            this.btnServerSeting = new System.Windows.Forms.Button();
            this.btn_createBackup = new System.Windows.Forms.Button();
            this.btn_clinic_info = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.msLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.msServerSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.msStyles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.msClinicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.إستعادةالنسخةالإحتياطيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.الموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموردينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المرضىToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(698, 206);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(139, 46);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "تسجيل الدخول ";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Location = new System.Drawing.Point(553, 206);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(139, 46);
            this.btnManageStaff.TabIndex = 7;
            this.btnManageStaff.Text = "إدارة الموظفين";
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.Click += new System.EventHandler(this.btnManageStaff_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.Location = new System.Drawing.Point(408, 206);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(139, 46);
            this.btn_supplier.TabIndex = 9;
            this.btn_supplier.Text = "إدارة الموردين";
            this.btn_supplier.UseVisualStyleBackColor = true;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // btnPatinet
            // 
            this.btnPatinet.Location = new System.Drawing.Point(263, 206);
            this.btnPatinet.Name = "btnPatinet";
            this.btnPatinet.Size = new System.Drawing.Size(139, 46);
            this.btnPatinet.TabIndex = 9;
            this.btnPatinet.Text = "إدارة المرضى";
            this.btnPatinet.UseVisualStyleBackColor = true;
            this.btnPatinet.Click += new System.EventHandler(this.btnPatinet_Click);
            // 
            // btnServerSeting
            // 
            this.btnServerSeting.Location = new System.Drawing.Point(553, 258);
            this.btnServerSeting.Name = "btnServerSeting";
            this.btnServerSeting.Size = new System.Drawing.Size(284, 46);
            this.btnServerSeting.TabIndex = 11;
            this.btnServerSeting.Text = "إعدادات السيرفر";
            this.btnServerSeting.UseVisualStyleBackColor = true;
            this.btnServerSeting.Click += new System.EventHandler(this.btnServerSeting_Click);
            // 
            // btn_createBackup
            // 
            this.btn_createBackup.Location = new System.Drawing.Point(263, 258);
            this.btn_createBackup.Name = "btn_createBackup";
            this.btn_createBackup.Size = new System.Drawing.Size(284, 46);
            this.btn_createBackup.TabIndex = 14;
            this.btn_createBackup.Text = "أنشاء نسخة أحتياطية";
            this.btn_createBackup.UseVisualStyleBackColor = true;
            this.btn_createBackup.Click += new System.EventHandler(this.btn_createBackup_Click);
            // 
            // btn_clinic_info
            // 
            this.btn_clinic_info.Location = new System.Drawing.Point(553, 319);
            this.btn_clinic_info.Name = "btn_clinic_info";
            this.btn_clinic_info.Size = new System.Drawing.Size(284, 46);
            this.btn_clinic_info.TabIndex = 16;
            this.btn_clinic_info.Text = "بيانات العيادة";
            this.btn_clinic_info.UseVisualStyleBackColor = true;
            this.btn_clinic_info.Click += new System.EventHandler(this.btn_clinic_info_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(263, 319);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(284, 46);
            this.btnRestore.TabIndex = 18;
            this.btnRestore.Text = "أستعادة نسخة أحتياطية";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 58);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msLogin,
            this.toolStripMenuItem1,
            this.msServerSetting,
            this.toolStripMenuItem2,
            this.msStyles,
            this.toolStripMenuItem3,
            this.إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem,
            this.إستعادةالنسخةالإحتياطيةToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Clinic_Management_System.Properties.Resources.Technology_32x32;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(97, 55);
            this.toolStripDropDownButton1.Text = "إعدادات النظام";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // msLogin
            // 
            this.msLogin.Image = global::Clinic_Management_System.Properties.Resources.icons8_Shutdown_16__1_;
            this.msLogin.Name = "msLogin";
            this.msLogin.Size = new System.Drawing.Size(230, 24);
            this.msLogin.Text = "تسجيل الدخول";
            this.msLogin.Click += new System.EventHandler(this.msLogin_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // msServerSetting
            // 
            this.msServerSetting.Name = "msServerSetting";
            this.msServerSetting.Size = new System.Drawing.Size(230, 24);
            this.msServerSetting.Text = "إعدادات السيرفر";
            this.msServerSetting.Click += new System.EventHandler(this.msServerSetting_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // msStyles
            // 
            this.msStyles.Name = "msStyles";
            this.msStyles.Size = new System.Drawing.Size(230, 24);
            this.msStyles.Text = "الإستايلات";
            this.msStyles.Click += new System.EventHandler(this.msStyles_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(227, 6);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msClinicInfo,
            this.toolStripMenuItem4,
            this.الموظفينToolStripMenuItem,
            this.الموردينToolStripMenuItem,
            this.المرضىToolStripMenuItem,
            this.المستخدمينToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::Clinic_Management_System.Properties.Resources.accessories_text_editor_32;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(111, 55);
            this.toolStripDropDownButton2.Text = "البيانات الأساسية";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButton2.ToolTipText = "البيانات الأساسية";
            // 
            // msClinicInfo
            // 
            this.msClinicInfo.Name = "msClinicInfo";
            this.msClinicInfo.Size = new System.Drawing.Size(152, 24);
            this.msClinicInfo.Text = "بيانات العيادة";
            this.msClinicInfo.Click += new System.EventHandler(this.msClinicInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblDate,
            this.toolStripStatusLabel5,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 24);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Image = global::Clinic_Management_System.Properties.Resources.if_user_285655;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 19);
            this.toolStripStatusLabel1.Text = "إسم المستخدم : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 19);
            this.toolStripStatusLabel2.Text = "لا يوجد";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Image = global::Clinic_Management_System.Properties.Resources.if_Christmas_Date_1651916;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(95, 19);
            this.toolStripStatusLabel3.Text = "تاريخ اليوم : ";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(81, 19);
            this.lblDate.Text = "00/00/0000";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Image = global::Clinic_Management_System.Properties.Resources.if_Watch_701487;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(105, 19);
            this.toolStripStatusLabel5.Text = "الوقت الحالي : ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(96, 19);
            this.lblTime.Text = "00:00:00 PM";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Clinic_Management_System.Properties.Resources.medicine;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(861, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem
            // 
            this.إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem.Name = "إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem";
            this.إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem.Text = "إنشاء نسخة إحتياطية للبيانات";
            // 
            // إستعادةالنسخةالإحتياطيةToolStripMenuItem
            // 
            this.إستعادةالنسخةالإحتياطيةToolStripMenuItem.Name = "إستعادةالنسخةالإحتياطيةToolStripMenuItem";
            this.إستعادةالنسخةالإحتياطيةToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.إستعادةالنسخةالإحتياطيةToolStripMenuItem.Text = "إستعادة النسخة الإحتياطية";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // الموظفينToolStripMenuItem
            // 
            this.الموظفينToolStripMenuItem.Name = "الموظفينToolStripMenuItem";
            this.الموظفينToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.الموظفينToolStripMenuItem.Text = "الموظفين";
            // 
            // الموردينToolStripMenuItem
            // 
            this.الموردينToolStripMenuItem.Name = "الموردينToolStripMenuItem";
            this.الموردينToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.الموردينToolStripMenuItem.Text = "الموردين";
            // 
            // المرضىToolStripMenuItem
            // 
            this.المرضىToolStripMenuItem.Name = "المرضىToolStripMenuItem";
            this.المرضىToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.المرضىToolStripMenuItem.Text = "المرضى";
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 453);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btn_clinic_info);
            this.Controls.Add(this.btn_createBackup);
            this.Controls.Add(this.btnServerSeting);
            this.Controls.Add(this.btn_supplier);
            this.Controls.Add(this.btnPatinet);
            this.Controls.Add(this.btnManageStaff);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشاشة الرئيسة ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Form_FormClosing);
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btnManageStaff;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Button btnPatinet;
        private System.Windows.Forms.Button btnServerSeting;
        private System.Windows.Forms.Button btn_createBackup;
        private System.Windows.Forms.Button btn_clinic_info;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem msLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msServerSetting;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem msStyles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem msClinicInfo;
        private System.Windows.Forms.ToolStripMenuItem إنشاءنسخةإحتياطيةللبياناتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem إستعادةالنسخةالإحتياطيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem الموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموردينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المرضىToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        //private System.Windows.Forms.Button btnPatinet;

    }
}