namespace Clinic_Management_System
{
    partial class frmServerSetting
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
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdoWin = new System.Windows.Forms.RadioButton();
            this.rdoSql = new System.Windows.Forms.RadioButton();
            this.btnCancle = new System.Windows.Forms.Button();
            this.RemeberSettings = new System.Windows.Forms.CheckBox();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtServerName.Location = new System.Drawing.Point(31, 31);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServerName.Size = new System.Drawing.Size(525, 27);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.Text = ".";
            this.txtServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(477, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "إسم السيرفر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(455, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "إسم المستخدم :";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPass.Location = new System.Drawing.Point(15, 102);
            this.txtPass.Name = "txtPass";
            this.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPass.Size = new System.Drawing.Size(526, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Enabled = false;
            this.pnlLogin.Location = new System.Drawing.Point(14, 97);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(559, 147);
            this.pnlLogin.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUser.Location = new System.Drawing.Point(15, 35);
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUser.Size = new System.Drawing.Size(526, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(463, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "كلمة المرور :";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Clinic_Management_System.Properties.Resources.save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(305, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حفظ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdoWin
            // 
            this.rdoWin.AutoSize = true;
            this.rdoWin.Checked = true;
            this.rdoWin.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoWin.Location = new System.Drawing.Point(183, 68);
            this.rdoWin.Name = "rdoWin";
            this.rdoWin.Size = new System.Drawing.Size(198, 23);
            this.rdoWin.TabIndex = 1;
            this.rdoWin.TabStop = true;
            this.rdoWin.Text = "Windows Authentication";
            this.rdoWin.UseVisualStyleBackColor = true;
            // 
            // rdoSql
            // 
            this.rdoSql.AutoSize = true;
            this.rdoSql.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rdoSql.Location = new System.Drawing.Point(393, 68);
            this.rdoSql.Name = "rdoSql";
            this.rdoSql.Size = new System.Drawing.Size(163, 23);
            this.rdoSql.TabIndex = 2;
            this.rdoSql.Text = "SQL Authentication";
            this.rdoSql.UseVisualStyleBackColor = true;
            this.rdoSql.CheckedChanged += new System.EventHandler(this.rdoSql_CheckedChanged);
            // 
            // btnCancle
            // 
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.FlatAppearance.BorderSize = 0;
            this.btnCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancle.ForeColor = System.Drawing.Color.Black;
            this.btnCancle.Image = global::Clinic_Management_System.Properties.Resources.Close_32x32;
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancle.Location = new System.Drawing.Point(208, 271);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(76, 31);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "إلغاء";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // RemeberSettings
            // 
            this.RemeberSettings.AutoSize = true;
            this.RemeberSettings.Font = new System.Drawing.Font("Tahoma", 13F);
            this.RemeberSettings.Location = new System.Drawing.Point(30, 65);
            this.RemeberSettings.Name = "RemeberSettings";
            this.RemeberSettings.Size = new System.Drawing.Size(134, 26);
            this.RemeberSettings.TabIndex = 7;
            this.RemeberSettings.Text = "تذكر الإعدادات";
            this.RemeberSettings.UseVisualStyleBackColor = true;
            // 
            // frmServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 321);
            this.Controls.Add(this.RemeberSettings);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.rdoSql);
            this.Controls.Add(this.rdoWin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إعدادات السيرفر";
            this.Load += new System.EventHandler(this.frmServerSetting_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdoWin;
        private System.Windows.Forms.RadioButton rdoSql;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.CheckBox RemeberSettings;
    }
}