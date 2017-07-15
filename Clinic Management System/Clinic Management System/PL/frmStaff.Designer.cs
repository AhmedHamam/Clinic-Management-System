namespace Clinic_Management_System
{
    partial class frmStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaff));
            this.pnlTabContent = new System.Windows.Forms.Panel();
            this.tmrRandomColorTab = new System.Windows.Forms.Timer(this.components);
            this.ucManageStaff1 = new Clinic_Management_System.ucManageStaff();
            this.btnManageStaff = new System.Windows.Forms.RadioButton();
            this.pnlUnderLineTab = new System.Windows.Forms.Panel();
            this.btnNewStaff = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTabContent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabContent
            // 
            this.pnlTabContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTabContent.Controls.Add(this.ucManageStaff1);
            this.pnlTabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabContent.Location = new System.Drawing.Point(0, 219);
            this.pnlTabContent.Name = "pnlTabContent";
            this.pnlTabContent.Size = new System.Drawing.Size(711, 276);
            this.pnlTabContent.TabIndex = 5;
            // 
            // tmrRandomColorTab
            // 
            this.tmrRandomColorTab.Enabled = true;
            this.tmrRandomColorTab.Interval = 1000;
            this.tmrRandomColorTab.Tick += new System.EventHandler(this.tmrRandomColorTab_Tick);
            // 
            // ucManageStaff1
            // 
            this.ucManageStaff1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucManageStaff1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucManageStaff1.Location = new System.Drawing.Point(0, 0);
            this.ucManageStaff1.Name = "ucManageStaff1";
            this.ucManageStaff1.Size = new System.Drawing.Size(707, 272);
            this.ucManageStaff1.TabIndex = 0;
            // 
            // btnManageStaff
            // 
            this.btnManageStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageStaff.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnManageStaff.Checked = true;
            this.btnManageStaff.FlatAppearance.BorderSize = 0;
            this.btnManageStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnManageStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStaff.Font = new System.Drawing.Font("Consolas", 10F);
            this.btnManageStaff.Location = new System.Drawing.Point(481, 17);
            this.btnManageStaff.Name = "btnManageStaff";
            this.btnManageStaff.Size = new System.Drawing.Size(117, 24);
            this.btnManageStaff.TabIndex = 2;
            this.btnManageStaff.TabStop = true;
            this.btnManageStaff.Text = "إدارة الموظفين";
            this.btnManageStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnManageStaff.UseVisualStyleBackColor = true;
            this.btnManageStaff.CheckedChanged += new System.EventHandler(this.btnManageStaff_CheckedChanged);
            // 
            // pnlUnderLineTab
            // 
            this.pnlUnderLineTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderLineTab.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlUnderLineTab.Location = new System.Drawing.Point(481, 44);
            this.pnlUnderLineTab.Name = "pnlUnderLineTab";
            this.pnlUnderLineTab.Size = new System.Drawing.Size(117, 3);
            this.pnlUnderLineTab.TabIndex = 3;
            // 
            // btnNewStaff
            // 
            this.btnNewStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewStaff.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNewStaff.FlatAppearance.BorderSize = 0;
            this.btnNewStaff.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewStaff.Font = new System.Drawing.Font("Consolas", 10F);
            this.btnNewStaff.Location = new System.Drawing.Point(604, 17);
            this.btnNewStaff.Name = "btnNewStaff";
            this.btnNewStaff.Size = new System.Drawing.Size(104, 24);
            this.btnNewStaff.TabIndex = 1;
            this.btnNewStaff.Text = "موظف جديد";
            this.btnNewStaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewStaff.UseVisualStyleBackColor = true;
            this.btnNewStaff.CheckedChanged += new System.EventHandler(this.btnNewStaff_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNewStaff);
            this.panel2.Controls.Add(this.pnlUnderLineTab);
            this.panel2.Controls.Add(this.btnManageStaff);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 61);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 158);
            this.panel1.TabIndex = 0;
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(711, 495);
            this.Controls.Add(this.pnlTabContent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الموظفين";
            this.pnlTabContent.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabContent;
        private System.Windows.Forms.Timer tmrRandomColorTab;
        private ucManageStaff ucManageStaff1;
        private System.Windows.Forms.RadioButton btnManageStaff;
        private System.Windows.Forms.Panel pnlUnderLineTab;
        private System.Windows.Forms.RadioButton btnNewStaff;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}