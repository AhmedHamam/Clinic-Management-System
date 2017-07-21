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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.msLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.msServerSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.msStyles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_createBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.msRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.msClinicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.الأشخاصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPatinet = new System.Windows.Forms.ToolStripMenuItem();
            this.msManageStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.msSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.إدارةالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.msCheckupManage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ms_createBackup,
            this.msRestore});
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
            // ms_createBackup
            // 
            this.ms_createBackup.Name = "ms_createBackup";
            this.ms_createBackup.Size = new System.Drawing.Size(230, 24);
            this.ms_createBackup.Text = "إنشاء نسخة إحتياطية للبيانات";
            this.ms_createBackup.Click += new System.EventHandler(this.ms_createBackup_Click);
            // 
            // msRestore
            // 
            this.msRestore.Name = "msRestore";
            this.msRestore.Size = new System.Drawing.Size(230, 24);
            this.msRestore.Text = "إستعادة النسخة الإحتياطية";
            this.msRestore.Click += new System.EventHandler(this.msRestore_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msClinicInfo,
            this.toolStripMenuItem4,
            this.الأشخاصToolStripMenuItem,
            this.toolStripMenuItem5,
            this.msCheckupManage});
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
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(149, 6);
            // 
            // الأشخاصToolStripMenuItem
            // 
            this.الأشخاصToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPatinet,
            this.msManageStaff,
            this.msSuppliers,
            this.إدارةالمستخدمينToolStripMenuItem});
            this.الأشخاصToolStripMenuItem.Name = "الأشخاصToolStripMenuItem";
            this.الأشخاصToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.الأشخاصToolStripMenuItem.Text = "الأشخاص";
            // 
            // msPatinet
            // 
            this.msPatinet.Name = "msPatinet";
            this.msPatinet.Size = new System.Drawing.Size(169, 24);
            this.msPatinet.Text = "إدارة المرضى";
            this.msPatinet.Click += new System.EventHandler(this.msPatinet_Click);
            // 
            // msManageStaff
            // 
            this.msManageStaff.Name = "msManageStaff";
            this.msManageStaff.Size = new System.Drawing.Size(169, 24);
            this.msManageStaff.Text = "إدارة الموظفين";
            this.msManageStaff.Click += new System.EventHandler(this.msManageStaff_Click);
            // 
            // msSuppliers
            // 
            this.msSuppliers.Name = "msSuppliers";
            this.msSuppliers.Size = new System.Drawing.Size(169, 24);
            this.msSuppliers.Text = "إدارة الموردين";
            this.msSuppliers.Click += new System.EventHandler(this.msSuppliers_Click);
            // 
            // إدارةالمستخدمينToolStripMenuItem
            // 
            this.إدارةالمستخدمينToolStripMenuItem.Name = "إدارةالمستخدمينToolStripMenuItem";
            this.إدارةالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.إدارةالمستخدمينToolStripMenuItem.Text = "إدارة المستخدمين";
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
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // msCheckupManage
            // 
            this.msCheckupManage.Name = "msCheckupManage";
            this.msCheckupManage.Size = new System.Drawing.Size(152, 24);
            this.msCheckupManage.Text = "إدارة الزيارات";
            this.msCheckupManage.Click += new System.EventHandler(this.msCheckupManage_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 453);
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
        private System.Windows.Forms.ToolStripMenuItem ms_createBackup;
        private System.Windows.Forms.ToolStripMenuItem msRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem الأشخاصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msPatinet;
        private System.Windows.Forms.ToolStripMenuItem msManageStaff;
        private System.Windows.Forms.ToolStripMenuItem msSuppliers;
        private System.Windows.Forms.ToolStripMenuItem إدارةالمستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem msCheckupManage;
        //private System.Windows.Forms.Button btnPatinet;

    }
}